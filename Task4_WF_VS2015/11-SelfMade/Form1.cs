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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = (this.checkBox1.Checked ? this.checkBox1.Name : "") + " " + (this.checkBox2.Checked ? this.checkBox2.Name : "");
            this.textBox2.Text = s;
        }
    }
}
