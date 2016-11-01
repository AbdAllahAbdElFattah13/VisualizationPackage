using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualization;
using System.Drawing;
using WindowsFormsControlLibrary1;



namespace Mesh_Loader_Task
{
    public static class VisualizationOperations
    {

        private static ColorMapping CM;

        public static void CalculateColorsValues(Mesh MeshMesh, uint Index,
            double Min, double Max,
            List<ValueAndPosition> EdgeValues, List<Color> EdgeColors,
            List<ValueAndPosition> FaceValues, List<Color> FaceColors)
        {
            CM = new ColorMapping();

            /*clearing if prev data exists*/
            EdgeValues.Clear();
            EdgeColors.Clear();
            FaceValues.Clear();
            FaceColors.Clear();

            ValueAndPosition VP;     
            foreach (Zone Z in MeshMesh.Zones)
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
    }
}
