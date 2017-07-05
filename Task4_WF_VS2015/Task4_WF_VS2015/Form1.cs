using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_WF_VS2015
{
    public partial class Form1 : Form
    {

        public Form2 f2;
        public Form3 f3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(f2, null))
            {
                f2 = new Form2();
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            if (f3.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Cancel");
            }
            f3.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }
    }
}
