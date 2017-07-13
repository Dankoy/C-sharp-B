using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String s1 = Convert.ToString(System.DateTime.Now);
            textBox1.Text = s1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Header", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
