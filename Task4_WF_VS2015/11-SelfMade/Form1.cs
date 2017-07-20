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

        private Form2 form2;

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

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromFile(dialog.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += changeTime;
            timer.Enabled = true;
        }
        private void changeTime(object sender, EventArgs e)
        {
            this.textBox4.Text = DateTime.Now.ToString("h:mm:ss");
        }

        // Hover for status strip
        private void statusStrip1_MouseHover(object sender, EventArgs e)
        {
            ((ToolStripStatusLabel)this.statusStrip1.Items[0]).Text = DateTime.Now.ToString("h:mm:ss");
            ((ToolStripStatusLabel)this.statusStrip1.Items[1]).Text = DateTime.Today.ToString("M/d/yyyy");
            ((ToolStripStatusLabel)this.statusStrip1.Items[2]).Text = this.BackColor.ToString();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            Graphics g = this.form2.CreateGraphics();
            g.FillRectangle(Brushes.Blue, 20, 10, 50, 70);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.form2 = new Form2();
            form2.Show();
        }
    }
}
