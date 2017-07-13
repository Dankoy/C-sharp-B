using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamWriter sw = System.IO.File.CreateText(saveFileDialog1.FileName))
                    sw.WriteLine(textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    textBox2.Text = "";
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        textBox2.AppendText(s);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    textBox2.Text = "";
                    string s = "";
                    textBox2.AppendText(sr.ReadToEnd());
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                BackColor = colorDialog1.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
                textBox2.ForeColor = colorDialog1.Color;
        }
    }
}
