using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualization;
using System.Drawing;
using WindowsFormsControlLibrary1;
using System.Diagnostics;

namespace Mesh_Loader_Task
{
    public static class VisualizationOperations
    {
        private static ColorMapping CM;

        static VisualizationOperations()
        {
            CM = new ColorMapping();
        }

        #region private helpers

        /// <summary>
        /// detarmin if there's point belongs to the current contour value crossing this edge or not.
        /// </summary>
        /// <param name="start">Edge start point</param>
        /// <param name="end">Edge end point</param>
        /// <param name="dataIndex">the data which we using to get the contour</param>
        /// <param name="contourValue">contour value which we are intersted in</param>
        /// <returns>The point position if there's a point, null otherwise</returns>
        /// <remarks>always play carefully with the NULLs!!</remarks>
       private static Point3 solveContourProblemForEdge(Vertex start, Vertex end, uint dataIndex, double contourValue)
       {
           Vertex minV = start.Data[dataIndex] < end.Data[dataIndex] ? start : end,
                      maxV = start.Data[dataIndex] > end.Data[dataIndex] ? start : end;

           double minValue = minV.Data[dataIndex],
                   maxValue = maxV.Data[dataIndex];
           
           //if there's a point belong to the contour and passes throw this edge
           if (minValue <= contourValue && contourValue <= maxValue)
           {
               //then this point position should defer from the min point by the same amount in which they defer in data "alpha"
               //calculating alpha from data to use to determain the contour point position
               double alpha = (contourValue - minValue) / (maxValue - minValue);
               double x = minV.Position.x + alpha * (maxV.Position.x - minV.Position.x),
                   y = minV.Position.y + alpha * (maxV.Position.y - minV.Position.y),
                   z = minV.Position.z + alpha * (maxV.Position.z - minV.Position.z);
               return new Point3(x, y, z);
           }
           return null;
       }

        private static List<Tuple<Point3, Point3>> solveContourProblemForTriangeFaec(List<Vertex> face, uint dataIndex, double contourValue)
        {
            if (face.Count != 3) throw new Exception("Found more or less than 3 points in a TriangeFace!");

            List<Tuple<Point3, Point3>> ret = new List<Tuple<Point3, Point3>>();
            //just in case if the whole face belong to the contour line
            if (face[0].Data[dataIndex] == face[1].Data[dataIndex] && face[1].Data[dataIndex] == face[2].Data[dataIndex] 
                && contourValue == face[2].Data[dataIndex])
            {
                ret.Add(new Tuple<Point3, Point3>(face[0].Position, face[1].Position));
                ret.Add(new Tuple<Point3, Point3>(face[1].Position, face[2].Position));
                ret.Add(new Tuple<Point3, Point3>(face[2].Position, face[0].Position));
            }
            else
            {
                Point3 s = null, e = null;

                //TODO: get red of inner loop!
                //only one edge can belong to the contuer, aka only two points
                int counPointsTest = 0;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = i + 1; j < 3; ++j)
                    {
                        Point3 p = solveContourProblemForEdge(face[i], face[j], dataIndex, contourValue);
                        if ((object)p != null)
                        {
                            ++counPointsTest;
                            if ((object)s == null) s = new Point3(p.coordinates);
                            else e = new Point3(p.coordinates);
                        }
                    }//end inner loop
                }//end the outer loop

                //just to make sure
                Debug.Assert(counPointsTest == 2 || counPointsTest == 0, counPointsTest.ToString() + "!!");

                if ((object)s != null && (object)e != null)
                    ret.Add(new Tuple<Point3, Point3>(s, e));
            }//end else
            return ret;
        }

        private static List< Tuple<Point3, Point3> > solveContourProblemForQuadFace(List<Vertex> face, uint dataIndex, double contourValue)
        {
            if (face.Count != 4) throw new Exception("Found more or less than 4 points in a QuadFace!");

            #region get inner point to split the quad face into 4 triangles :D
            double xx = 0, yy = 0, zz = 0;
            Vertex innerPoint = new Vertex(ref xx, ref yy, ref zz, (uint)face[0].Data.Length);
            innerPoint.Data[dataIndex] = 0;
            foreach(Vertex v in face)
            {
                innerPoint.Position.x += v.Position.x;
                innerPoint.Position.y += v.Position.y; 
                innerPoint.Position.z += v.Position.z;
                innerPoint.Data[dataIndex] += v.Data[dataIndex];
            }

            innerPoint.Position.x /= 4;
            innerPoint.Position.y /= 4;
            innerPoint.Position.z /= 4;
            innerPoint.Data[dataIndex] /= 4;
            #endregion

            List<Tuple<Point3, Point3>> ret = new List<Tuple<Point3, Point3>>();
            for (int i = 0; i < face.Count; ++i)
            {
                //I read this line after almost a year from me writing it!
                //well done old me, well done! :D
                ret.AddRange(solveContourProblemForTriangeFaec(new List<Vertex>() { face[i], face[(i + 1) % face.Count], innerPoint }, dataIndex, contourValue));
            }
            return ret;
        }

        private static Contour CalculateContour(Mesh m, uint dataIndex, double minData, double maxData, double contourValue)
        {
            //just to make it a fresh contour, and also to add its color and value
            Contour outContour = new Contour(CM.ValueToColor((float)maxData, (float)minData, (float)contourValue), contourValue);

            foreach (Zone z in m.Zones)
            {
                List<Tuple<Point3, Point3>> curEdges = null;
                foreach (Face f in z.Faces)
                {
                    List<Vertex> faceVertices = new List<Vertex>();

                    for (int i = 0; i < f.Vertices.Length; ++i)
                        faceVertices.Add(z.Vertices[f.Vertices[i]]);
                    
                    switch (f.Edges.Length)
                    {
                        case 3:
                            curEdges = solveContourProblemForTriangeFaec(faceVertices, dataIndex, contourValue);
                            break;
                        case 4:
                            curEdges = solveContourProblemForQuadFace(faceVertices, dataIndex, contourValue);
                            break;
                        default:
                            throw new Exception("un-known face!, known faces are (3 || 4)");
                    }//end switch
                    if ((object)curEdges != null && curEdges.Count > 0)
                        outContour.edges.AddRange(curEdges);
                }//end faces loop
            }//end zones loop

            return outContour;
        }//end of function

        #endregion

        #region public interface
        public static List<Contour> CalculateContours(Mesh m, int numberOfContours, uint dataIndex, double minData, double maxData)
        {
            List <Contour> contours = new List<Contour>();
            if (numberOfContours <= 0) return contours;
            double step = (maxData - minData) / (numberOfContours + 1), contourValue = minData + step;

            return CalculateContours(m, dataIndex, minData, maxData, step);
        }

        public static List<Contour> CalculateContours(Mesh m, uint dataIndex, double minData, double maxData, double step)
        {
            List<Contour> contours = new List<Contour>();
            double contourValue = minData;

            //for (int i = 1; i <= numberOfContours; ++i )
            while (contourValue < maxData)
            {
                //if (contourValue > maxData) break;
                Contour c = CalculateContour(m, dataIndex, minData, maxData, contourValue);
                contours.Add(c);

                contourValue += step;
            }

            return contours;
        }

        public static void CalculateColorsValues(Mesh m, uint Index,
            double Min, double Max,
            List<ValueAndPosition> EdgeValues, List<Color> EdgeColors,
            List<ValueAndPosition> FaceValues, List<Color> FaceColors)
        {
            /*clearing if prev data exists*/
            EdgeValues.Clear();
            EdgeColors.Clear();
            FaceValues.Clear();
            FaceColors.Clear();

            ValueAndPosition VP;
            foreach (Zone Z in m.Zones)
            {
                foreach (Face F in Z.Faces)
                {
                    double FaceValue = 0;
                    VP = new ValueAndPosition();
                    Point3 P = new Point3(0, 0, 0);

                    for (int i = 0; i < F.Vertices.Length; ++i)
                    {
                        FaceValue += Z.Vertices[F.Vertices[i]].Data[Index];
                        P.x += Z.Vertices[F.Vertices[i]].Position.x;
                        P.y += Z.Vertices[F.Vertices[i]].Position.y;
                    }
                    P.x /= F.Vertices.Length;
                    P.y /= F.Vertices.Length;

                    FaceValue /= F.Vertices.Length;
                    Color FaceColor = CM.ValueToColor((float)Max, (float)Min, (float)FaceValue);
                    VP.point = new Point3(P.coordinates);
                    //VP.point = new Point3(Z.Vertices[F.Vertices[F.Vertices.Length - 1]].Position.coordinates);
                    VP.value = FaceValue;
                    FaceValues.Add(VP);
                    FaceColors.Add(FaceColor);

                    foreach (uint EN in F.Edges)
                    {
                        Edge E = Z.Edges[EN];
                        VP = new ValueAndPosition();

                        double EdgeValue = (Z.Vertices[E.Start].Data[Index] + Z.Vertices[E.End].Data[Index]) / 2;
                        Color EdgeColor = CM.ValueToColor((float)Max, (float)Min, (float)EdgeValue);
                        float x = (float)((Z.Vertices[E.Start].Position.x + Z.Vertices[E.End].Position.x) / 2.0);
                        float y = (float)((Z.Vertices[E.Start].Position.y + Z.Vertices[E.End].Position.y) / 2.0);


                        VP.point = new Point3(x, y, 1);
                        VP.value = EdgeValue;
                        EdgeValues.Add(VP);

                        EdgeColors.Add(EdgeColor);



                    }//End of Edges
                }//End of Faces
            }//End of Zones

        }

        #endregion
    }// end of class
}