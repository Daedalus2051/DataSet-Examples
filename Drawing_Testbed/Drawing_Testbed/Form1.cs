using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Testbed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;

            PaintEventArgs pea = new PaintEventArgs(g, new Rectangle());

            DrawLinesPoint(pea);
        }

        public void DrawLinesPoint(PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);

            Point[] points =
            {
                new Point(10,10),
                new Point(10,100),
                new Point(200,50),
                new Point(250,300)
            };

            e.Graphics.DrawLines(p, points);
        }
    }
}
