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
    public partial class Form2 : Form
    {
        public Object fo;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Object f)
        {
            fo = (Form1)f;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            //Changed so it actually has object, not null.
            ((Form1)fo).f2.Dispose();
            ((Form1)fo).f2 = null;
        }
    }
}
