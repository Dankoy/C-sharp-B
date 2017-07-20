using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_SelfMade
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            string s = "X: " + e.X + " Y: " + e.Y + " time: " + DateTime.Now.ToString("h:mm:ss");
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightGray);
            System.Drawing.Font fn = new Font("Arial", 16);
            Brush br = new SolidBrush(Color.Black);
            PointF drawPoint = new Point(50, 50);
            g.DrawString(s, fn, br, drawPoint);
        }
    }
}
