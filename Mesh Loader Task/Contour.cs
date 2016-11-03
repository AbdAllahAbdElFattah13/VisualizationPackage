using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visualization;
using System.Drawing;
using Tao.OpenGl;

namespace Mesh_Loader_Task
{
    public class Contour
    {
        public List<Tuple<Point3, Point3> > edges;
        public Color color;
        public double value { get; private set; }

        public Contour(Color c, double v)
        {
            this.edges = new List<Tuple<Point3, Point3>>();
            this.color = c;
            this.value = v;
        }

        public Contour() : this(Color.Black, double.MinValue) { }

        public void Clear()
        {
            this.edges.Clear();
            this.color = Color.Black;
            this.value = double.MinValue;
        }

        public void Draw()
        {
            Gl.glBegin(Gl.GL_LINES);
            {
                Gl.glColor3d(color.R / 255.0, color.G / 255.0, color.B / 255.0);
                foreach (var t in edges)
                {
                    t.Item1.glTell();
                    t.Item2.glTell();
                }
            }
            Gl.glEnd();
        }
    }


}
