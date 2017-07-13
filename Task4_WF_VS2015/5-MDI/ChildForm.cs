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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }
        private void ChildForm_Click(object sender, EventArgs e)
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
