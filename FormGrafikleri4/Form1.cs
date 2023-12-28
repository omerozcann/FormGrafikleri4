using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGrafikleri4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graph = this.CreateGraphics();
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int r, g, b,x,y;
                r = rnd.Next(256);
                g = rnd.Next(256);
                b = rnd.Next(256);
                Color c=Color.FromArgb(r, g, b);
                x = rnd.Next(this.Width);
                y = rnd.Next(this.Height);
                SolidBrush brush = new SolidBrush(c);// rengi fırçaya dönüştür
                graph.FillEllipse(brush, x, y, 50, 50);
            }
        }
    }
}
