using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2_OleDBDataAdapter_Usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       //     oleDbDataAdapter1.Fill(this.dataSet11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int par = Int32.Parse(this.textBox1.Text);
            oleDbDataAdapter1.SelectCommand.Parameters[0].Value = par;

            this.dataSet11.Clear();
            oleDbDataAdapter1.Fill(this.dataSet11);

            if (this.listBox1.SelectedIndex != -1)
            {
                String s = this.listBox1.SelectedValue.ToString();
                // MessageBox.Show(this.listBox1.SelectedValue.ToString());
                oleDbDataAdapter2.SelectCommand.Parameters[0].Value = Int32.Parse(s);
                this.dataSet21.Clear();
                oleDbDataAdapter2.Fill(dataSet21);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                String s = this.listBox1.SelectedValue.ToString();
                // MessageBox.Show(this.listBox1.SelectedValue.ToString());
                oleDbDataAdapter2.SelectCommand.Parameters[0].Value = Int32.Parse(s);
                this.dataSet21.Clear();
                oleDbDataAdapter2.Fill(dataSet21);
            }
        }
    }
}
