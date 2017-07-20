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

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text += this.textBox3.Text + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                this.richTextBox1.SaveFile(dialog.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                this.richTextBox1.LoadFile(dialog.FileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            this.richTextBox1.SelectionColor = dialog.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            this.richTextBox1.SelectionBackColor = dialog.Color;
        }
    }
}
