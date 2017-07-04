using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndowsForms1
{
    public partial class Form1 : Form
    {
        public  Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(f2, null))
            {
                f2 = new Form2(this);
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
