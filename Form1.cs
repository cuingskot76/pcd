using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcd_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = "bmp";

            ofd.Filter = "image files|*.png; *.jpg *.bmp; *.jpeg";

            if(ofd.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                Bitmap bmp = new Bitmap(pictureBox1.Image);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            int r, g, b;

            Color p;

            p = bmp.GetPixel(0, 0);
            r = p.R;
            g = p.G;
            b = p.B;

            Console.WriteLine("(0, 0) : R=" + r);
            Console.WriteLine("(0, 0) : G=" + g);
            Console.WriteLine("(0, 0) : B=" + b);

            int m = bmp.Height;
            int n = bmp.Width;

            Color q = bmp.GetPixel(n - 1, m - 1);
            r = q.R;
            g = q.G;
            b = q.B;

            Console.WriteLine("(" + (n - 1) + "," + (m - 1) + ") : R=" + r);
            Console.WriteLine("(" + (n - 1) + "," + (m - 1) + ") : G=" + g);
            Console.WriteLine("(" + (n - 1) + "," + (m - 1) + ") : B=" + b);
        }
    }
}
