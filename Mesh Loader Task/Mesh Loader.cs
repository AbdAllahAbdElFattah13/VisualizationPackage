using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visualization;
using Tao.OpenGl;
using WindowsFormsControlLibrary1;
using Tao.FreeGlut;
namespace Mesh_Loader_Task
{
    public partial class MeshLoaderForm : Form
    {
        Mesh MeshMesh;
        double X, Y;
        bool ToggleDisplayValues = false;

        List<ValueAndPosition> EdgeValues;
        List<Color> EdgeColors;
        List<ValueAndPosition> FaceValues;
        List<Color> FaceColors;


        public MeshLoaderForm()
        {
            InitializeComponent();
            InitializeGraphics();
            EdgeValues = new List<ValueAndPosition>();
            EdgeColors = new List<Color>();
            FaceValues = new List<ValueAndPosition>();
            FaceColors = new List<Color>();
            //this.DataComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void InitializeGraphics()
        {
            SimpleOpenGlControl.InitializeContexts();
            SimpleOpenGlControl.Paint += new PaintEventHandler(SimpleOpenGlControl_Paint);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glut.glutInit();
            //Glut.glutInitWindowSize(500, 500);

            //Glu.gluOrtho2D(-100, 100, -100, 100);
            //Glu.gluPerspective(90.0f, (double)SimpleOpenGlControl.Height / (double)SimpleOpenGlControl.Width, 0.01f, 5000.0f);
            //Glu.gluPerspective(60, this.Width / this.Height, 0, 100);
        }

        private void Reset()
        {
            Gl.glPopMatrix();
            Gl.glPushMatrix();

            FaceColoringBox.Checked = false;
            EdgeColoringBox.Checked = false;

            DataComboBox.Text = "";
            DataComboBox.Items.Clear();

            ToggleDisplayValues = false;
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();  //Display a dialog box that allow the user to open a file.

            if (FD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Reset();

                    //FilePathText.Text = FD.FileName;
                    MeshMesh = new Mesh(FD.FileName, 1);

                    if (MeshMesh != null)
                    {
                        //Load Data in Combobox;
                        foreach (string Name in MeshMesh.VarToIndex.Keys)
                            DataComboBox.Items.Add(Name);

                        MessageBox.Show("File Loaded Successfully.\n\nMesh Title: " + MeshMesh.Title);
                        Gl.glLoadMatrixd(MeshMesh.Transformation.Data); //Load in center.

                        double Min, Max;
                        MeshMesh.GetMinMaxValues(0, out  Min, out Max);
                        VisualizationOperations.CalculateColorsValues(MeshMesh, 0, Min, Max, EdgeValues, EdgeColors, FaceValues, FaceColors);
                        

                        SimpleOpenGlControl.Invalidate();  //Update and redraw.
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Failed to Load File.\n" + E.Message);
                    return;
                }
            }
        }

        private void SimpleOpenGlControl_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(HandleTransformation);
        }

        private void HandleTransformation(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Gl.glTranslatef(0f, 0.5f, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.S)
            {
                Gl.glTranslatef(0f, -0.5f, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.A)
            {
                Gl.glTranslatef(-0.5f, 0f, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.D)
            {
                Gl.glTranslatef(0.5f, 0f, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.Z)
            {
                Gl.glTranslatef((float)X, (float)Y, 0f);
                Gl.glScalef(0.5f, 0.5f, 0f);
                Gl.glTranslatef((float)-X, (float)-Y, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.X)
            {
                Gl.glTranslatef((float)X, (float)Y, 0f);
                Gl.glScalef(2f, 2f, 0f);
                Gl.glTranslatef((float)-X, (float)-Y, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.R)
            {
                Gl.glTranslatef((float)X, (float)Y, 0f);
                Gl.glRotatef(20f, 0f, 0f, 1f);
                Gl.glTranslatef((float)-X, (float)-Y, 0f);
                SimpleOpenGlControl.Refresh();
            }

            else if (e.KeyCode == Keys.T)
            {
                Gl.glTranslatef((float)X, (float)Y, 0f);
                Gl.glRotatef(20f, 1f, 0f, 0f);
                Gl.glTranslatef((float)-X, (float)-Y, 0f);
                SimpleOpenGlControl.Refresh();
            }
            else if (e.KeyCode == Keys.Y)
            {
                Gl.glTranslatef((float)X, (float)Y, 0f);
                Gl.glRotatef(20f, 0f, 1f, 0f);
                Gl.glTranslatef((float)-X, (float)-Y, 0f);
                SimpleOpenGlControl.Refresh();
            }
        }

        private void SimpleOpenGlControl_Paint(object sender, PaintEventArgs e)
        {
            if (MeshMesh == null)  //If the file is not loaded and the mesh = null, don't draw.
                return;

            DrawMesh();
        }

        void DrawMesh()
        {
            int IndexOfEdgeColors = 0, IndexOfFaceColors = -1;
            float X_Min = float.MaxValue, X_Max = float.MinValue, Y_Min = float.MaxValue, Y_Max = float.MinValue;

            Gl.glClearColor(0, 0, 0, 0);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            foreach (Zone Z in MeshMesh.Zones)
            {
                foreach (Face F in Z.Faces)
                {
                    if (FaceColoringBox.Checked)
                        Gl.glBegin(Gl.GL_POLYGON);
                    else
                        Gl.glBegin(Gl.GL_LINES);

                    IndexOfFaceColors++;
                    foreach (uint EN in F.Edges)
                    {
                        Edge E = Z.Edges[EN];

                        if (EdgeColoringBox.Checked)
                        {
                            Color EdgeColor = EdgeColors[IndexOfEdgeColors];
                            Gl.glColor3d(EdgeColor.R / 255.0, EdgeColor.G / 255.0, EdgeColor.B / 255.0);
                            IndexOfEdgeColors++;
                        }
                        else if (FaceColoringBox.Checked)
                        {
                            Color FaceColor = FaceColors[IndexOfFaceColors];
                            Gl.glColor3d(FaceColor.R / 255.0, FaceColor.G / 255.0, FaceColor.B / 255.0);
                        }
                        else
                            Gl.glColor3d(1, 1, 1);

                        Z.Vertices[E.Start].Position.glTell();
                        Z.Vertices[E.End].Position.glTell();

                        //Get Minimum X, Minimum Y, Maximum X and Maximum Y.
                        X_Min = Math.Min((float)Z.Vertices[E.Start].Position.x, X_Min);
                        X_Max = Math.Max((float)Z.Vertices[E.Start].Position.x, X_Max);
                        Y_Min = Math.Min((float)Z.Vertices[E.Start].Position.y, Y_Min);
                        Y_Max = Math.Max((float)Z.Vertices[E.Start].Position.y, Y_Max);
                        X_Min = Math.Min((float)Z.Vertices[E.End].Position.x, X_Min);
                        X_Max = Math.Max((float)Z.Vertices[E.End].Position.x, X_Max);
                        Y_Min = Math.Min((float)Z.Vertices[E.End].Position.y, Y_Min);
                        Y_Max = Math.Max((float)Z.Vertices[E.End].Position.y, Y_Max);

                    }
                    Gl.glEnd();
                    Gl.glFlush();
                }
            }
            //Get the midpoint.
            X = (X_Max + X_Min) / 2;
            Y = (Y_Max + Y_Min) / 2;

            if (ToggleDisplayValues)
            {
                if (EdgeColoringBox.Checked)
                    DisplayValues(EdgeValues, Color.PeachPuff);
                else if (FaceColoringBox.Checked)
                    DisplayValues(FaceValues, Color.White);
            }
        }

        private bool CheckData()
        {
            if (DataComboBox.Text == "")
            {
                EdgeColoringBox.Checked = false;
                FaceColoringBox.Checked = false;
                MessageBox.Show("Please select data first.");
                return false;
            }
            return true;
        }

        private void EdgeColoringBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EdgeColoringBox.Checked == false || CheckData() == false)
                return;
            SimpleOpenGlControl.Invalidate();
        }

        private void FaceColoringBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FaceColoringBox.Checked == false || CheckData() == false)
                return;
            SimpleOpenGlControl.Invalidate();
        }

        private void DataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Data = DataComboBox.SelectedItem.ToString();
            uint Index = (uint)MeshMesh.VarToIndex[Data];
            double Max, Min;

            MeshMesh.GetMinMaxValues(Index, out  Min, out Max);
            MaxValueLabel.Text = Max.ToString();
            MinValueLabel.Text = Min.ToString();

            VisualizationOperations.CalculateColorsValues(MeshMesh, Index, Min, Max, EdgeValues, EdgeColors, FaceValues, FaceColors);
            SimpleOpenGlControl.Invalidate();
        }

        private void DisplayValuesButton_Click(object sender, EventArgs e)
        {
            ToggleDisplayValues = !ToggleDisplayValues;
            this.Refresh();
        }

        private void DisplayValues(List<ValueAndPosition> list, Color TextColor)
        {
            Gl.glColor3d(TextColor.R / 255.0, TextColor.G / 255.0, TextColor.B / 255.0);

            for (int i = 0; i < list.Count(); ++i)
            {
                Gl.glRasterPos2f((float)list[i].point.x, (float)list[i].point.y);
                foreach (char c in Math.Round(list[i].value, 3).ToString())
                {
                    Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_HELVETICA_10, c);
                }
            }
        }
    }
}
