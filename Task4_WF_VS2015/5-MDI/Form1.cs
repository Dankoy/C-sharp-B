using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newForm = new ChildForm();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            int r, g, b;
            Random ran = new Random();
            r = ran.Next(0, 255);
            g = ran.Next(0, 255);
            b = ran.Next(0, 255);
            Color c = Color.FromArgb(r, g, b);
            this.BackColor = c;

            this.Text = c.ToString();
        }
    }
}
