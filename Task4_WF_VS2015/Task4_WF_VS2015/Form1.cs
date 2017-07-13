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
    }
}
