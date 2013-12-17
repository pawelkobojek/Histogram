using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GKLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] HistogramR = new int[256];
        private int[] HistogramG = new int[256];
        private int[] HistogramB = new int[256];

        private int[] StrechedHistogramR = new int[256];
        private int[] StrechedHistogramB = new int[256];
        private int[] StrechedHistogramG = new int[256];

        private void Form1_Load(object sender, EventArgs e)
        {
            openImageDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";

            if (openImageDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxOrigin.Image = Image.FromFile(openImageDialog.FileName);
            }
            else
            {
                this.Close();
            }

            Bitmap bitmap = (Bitmap)pictureBoxOrigin.Image;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    HistogramR[c.R]++;
                    HistogramG[c.G]++;
                    HistogramB[c.B]++;
                }
            }

            chartOrigin.ChartAreas[0].AxisX.Minimum = 0;
            chartOrigin.ChartAreas[0].AxisX.Maximum = 255;
            chartStreched.ChartAreas[0].AxisX.Minimum = 0;
            chartStreched.ChartAreas[0].AxisX.Maximum = 255;

            chartOrigin.Series.Add(new Series("Red") { Color = Color.Red });
            chartOrigin.Series.Add(new Series("Green") { Color = Color.Green });
            chartOrigin.Series.Add(new Series("Blue") { Color = Color.Blue });

            chartStreched.Series.Add(new Series("Red") { Color = Color.Red });
            chartStreched.Series.Add(new Series("Green") { Color = Color.Green });
            chartStreched.Series.Add(new Series("Blue") { Color = Color.Blue });

            for (int i = 0; i < HistogramR.Length; i++)
            {
                chartOrigin.Series["Red"].Points.AddXY(i, HistogramR[i]);
                chartOrigin.Series["Green"].Points.AddXY(i, HistogramG[i]);
                chartOrigin.Series["Blue"].Points.AddXY(i, HistogramB[i]);
            }
        }

        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            Bitmap stretchedBmp = StretchHistogram((Bitmap)pictureBoxOrigin.Image);

            pictureBoxStretch.Image = stretchedBmp;
        }

        private Bitmap StretchHistogram(Bitmap bitmap)
        {
            StrechedHistogramR = new int[256];
            StrechedHistogramB = new int[256];
            StrechedHistogramG = new int[256];

            Bitmap streched = new Bitmap(bitmap.Width, bitmap.Height);

            int rMax, gMax, bMax, rMin, gMin, bMin;

            rMax = GetMax(HistogramR);
            gMax = GetMax(HistogramG);
            bMax = GetMax(HistogramB);
            rMin = GetMin(HistogramR);
            gMin = GetMin(HistogramG);
            bMin = GetMin(HistogramB);

            for (int x = 0; x < streched.Width; x++)
            {
                for (int y = 0; y < streched.Height; y++)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    int newR = (255 * (oldColor.R - rMin)) / (rMax - rMin);
                    int newG = (255 * (oldColor.G - gMin)) / (gMax - gMin);
                    int newB = (255 * (oldColor.B - bMin)) / (bMax - bMin);

                    Color newColor = Color.FromArgb(255, newR, newG, newB);
                    streched.SetPixel(x, y, newColor);

                    StrechedHistogramR[newR]++;
                    StrechedHistogramG[newG]++;
                    StrechedHistogramB[newB]++;
                }
            }

            for (int i = 0; i < StrechedHistogramR.Length; i++)
            {
                chartStreched.Series["Red"].Points.AddXY(i, StrechedHistogramR[i]);
                chartStreched.Series["Green"].Points.AddXY(i, StrechedHistogramG[i]);
                chartStreched.Series["Blue"].Points.AddXY(i, StrechedHistogramB[i]);
            }

            return streched;
        }

        private int GetMin(int[] Histogram)
        {
            for (int i = 0; i < 255; i++)
            {
                if (Histogram[i] != 0)
                    return i;
            }
            return 0;
        }

        private static int GetMax(int[] Histogram)
        {
            for (int i = 255; i >= 0; i--)
            {
                if (Histogram[i] != 0)
                {
                    return i;
                }
            }

            return 0;
        }

        private void checkBoxR_CheckedChanged(object sender, EventArgs e)
        {
            chartOrigin.Series["Red"].Enabled = checkBoxR.Checked;
            chartStreched.Series["Red"].Enabled = checkBoxR.Checked;
        }

        private void checkBoxG_CheckedChanged(object sender, EventArgs e)
        {
            chartOrigin.Series["Green"].Enabled = checkBoxG.Checked;
            chartStreched.Series["Green"].Enabled = checkBoxG.Checked;
        }

        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {
            chartOrigin.Series["Blue"].Enabled = checkBoxB.Checked;
            chartStreched.Series["Blue"].Enabled = checkBoxB.Checked;
        }


    }
}
