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

        public Form2 f2;        // 1 task 
        public Form3 f3;        // 1 task

        public Graphics g;      // 2 task

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel2.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //
        // First task for creating forms
        //

        private void button1_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(f2, null))
            {
                f2 = new Form2();
                f2.Show();
            }
        }


        // Show modal dialogs
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


        // Creating FOrm2 as anonymous object
        private void button3_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }



        //
        // End of first task
        //

        //
        // Begining of second task
        //
        
        private void button4_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, 10, 10, 60, 60);     // g - graphical context
            pen.Dispose();  // Freeing pen
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            pen.Width = 8F;
            g.DrawRectangle(pen, 10, 80, 70, 50);
            pen.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Brush myBrush = Brushes.GreenYellow;
            g.FillRectangle(myBrush, 10, 150, 70, 50);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Font myFont = new Font("Helvetica", 22);
            Brush myBrush = Brushes.DarkOrchid;
            g.DrawString("Hello, World", myFont, myBrush, 10, 200);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Font myFont = new Font("Helvetica", 22);
            Brush myBrush = Brushes.DarkOrchid;
            g.DrawString("Arbitrary string", myFont, myBrush, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue);
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel; // Скошенные углы
            pen.Width = 2.0F;
            g.DrawRectangle(pen,
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text)); // Параметры: (перо, x, y, ширина, высота)
            pen.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Tomato);
            g.DrawEllipse(pen,
                Convert.ToSingle(textBox1.Text),
                Convert.ToSingle(textBox2.Text),
                Convert.ToSingle(textBox3.Text),
                Convert.ToSingle(textBox4.Text));
            pen.Dispose(); // Освобождение пера
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(this.panel3.Size.Width);
            textBox6.Text = Convert.ToString(this.panel3.Size.Height);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(this.Size.Width);
            textBox6.Text = Convert.ToString(this.Size.Height);
        }

        //
        // Finishing of second task
        //
    }
}
