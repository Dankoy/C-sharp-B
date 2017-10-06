using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleDbDataAdapter_Usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  //          oleDbDataAdapter1.Fill(this.dataSet11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int par = Int32.Parse(this.textBox1.Text);
            oleDbDataAdapter1.SelectCommand.Parameters[0].Value = par;
            this.dataSet11.Clear();
            oleDbDataAdapter1.Fill(this.dataSet11);
        }
    }
}
