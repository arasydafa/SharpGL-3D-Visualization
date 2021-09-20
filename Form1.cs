using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL.SceneGraph.Primitives;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph;
using SharpGL;
using SharpGL.Serialization;
using SharpGL.SceneGraph.Core;
using SharpGL.Enumerations;
using System.IO.Ports;

namespace SharpGL_3D_Visualization
{
    public partial class Form1 : Form
    {
        String data;
        string[] split;
        double roll, pitch, yaw;

        Texture texture = new Texture();
        List<Polygon> polygons = new List<Polygon>();
        double rotate = 0;

        string binAppPath = Application.StartupPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl1_Load(object sender, EventArgs e)
        {
            try
            {
                OpenGL gl = this.openGLControl1.OpenGL;
                gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
                gl.LoadIdentity();
                gl.LookAt(-10, -15, 0, 0, 0, 0, 0, 1, 0);
                gl.Translate(0, 0, 0);

                foreach (Polygon polygon in polygons)
                {
                    polygon.PushObjectSpace(gl);
                    polygon.Render(gl, RenderMode.Render);
                    polygon.PopObjectSpace(gl);
                }
                rotate += 1.0f;

                Scene scene = SerializationEngine.Instance.LoadScene(binAppPath + "\\3D Files\\UHFSatcom.obj");
                if (scene != null)
                {
                    foreach (var polygon in scene.SceneContainer.Traverse<Polygon>())
                    {
                        BoundingVolume volume = polygon.BoundingVolume;
                        float[] extent = new float[3];
                        polygon.BoundingVolume.GetBoundDimensions(out extent[0], out extent[1], out extent[2]);
                        float maxExtent = extent.Max();
                        float scaleFactor = maxExtent > 10 ? 10.0f / maxExtent : 1;
                        polygon.Transformation.ScaleX = scaleFactor;
                        polygon.Transformation.ScaleY = scaleFactor;
                        polygon.Transformation.ScaleZ = scaleFactor;
                        polygon.Freeze(openGLControl1.OpenGL);
                        polygons.Add(polygon);
                    }
                }

                texture.Destroy(openGLControl1.OpenGL);
                texture.Create(openGLControl1.OpenGL, binAppPath + "\\3DModel\\payload1-texture.jpg");
                openGLControl1.Invalidate();

                openGLControl1.OpenGL.PolygonMode(FaceMode.FrontAndBack, PolygonMode.Filled);
                openGLControl1.OpenGL.Enable(OpenGL.GL_LIGHTING);
                openGLControl1.OpenGL.Enable(OpenGL.GL_LIGHT0);
                openGLControl1.OpenGL.Enable(OpenGL.GL_COLOR_MATERIAL);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] comPort = SerialPort.GetPortNames();
                foreach (string port in comPort)
                {
                    comPortDropdown.AddItem(port);
                }

                string[] baudRate = { "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200" };
                foreach (string baud in baudRate)
                {
                    baudRateDropdown.AddItem(baud);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.data = serialPort.ReadLine();
                this.BeginInvoke(new EventHandler(splitData));
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void splitData(object sender, EventArgs s)
        {
            split = data.Split(',');

            try
            {
                convertData();
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = "ERROR : " + ex.Message.ToString();
            }
        }

        private void connectPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen == false)
                {
                    serialPort.PortName = comPortDropdown.selectedValue;
                    serialPort.BaudRate = Int32.Parse(baudRateDropdown.selectedValue);
                    serialPort.NewLine = "\n\r";
                    serialPort.Close();
                    serialPort.Open();
                    toolStripLabel1.Text = "Connected to " + serialPort.PortName;
                }
                else if (serialPort.IsOpen == true)
                {
                    serialPort.Close();
                    toolStripLabel1.Text = "Disconnected from " + serialPort.PortName;
                }
            }
            catch (Exception ex)
            {
                toolStripLabel1.Text = "ERROR : " + ex.Message.ToString();
            }
        }

        private void refreshPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();

                comPortDropdown.Clear();
                string[] MyComPort = SerialPort.GetPortNames();
                foreach (string ComPort in MyComPort)
                {
                    comPortDropdown.AddItem(ComPort);
                }

                baudRateDropdown.Clear();
                string[] baudRate = { "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200" };
                foreach (string baud in baudRate)
                {
                    baudRateDropdown.AddItem(baud);
                }

                toolStripLabel1.Text = "COM Port Refreshed";
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void convertData()
        {
            try
            {
                roll = Convert.ToDouble(split[0]);
                pitch = Convert.ToDouble(split[1]);
                yaw = Convert.ToDouble(split[2]);

                this.BeginInvoke(new EventHandler(showData));
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void showData(object sender, EventArgs e)
        {
            rollValue.Text = String.Format("{0:000.00}", roll);
            pitchValue.Text = String.Format("{0:000.00}", pitch);
            yawValue.Text = String.Format("{0:000.00}", yaw);
        }
    }
}
