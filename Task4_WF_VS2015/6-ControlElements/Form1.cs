using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_ControlElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        // CHange text in button 1
        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Text = this.textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(this.radioButton1.Checked || this.radioButton2.Checked))
            {
                MessageBox.Show("Choose image");
            }
            else if (this.radioButton1.Checked)
            {   //CHosed 1 radiobutton
                this.button1.Image = Image.FromFile("C:\\Users\\Evgeny\\VS Projects\\C-sharp-B\\Task4_WF_VS2015\\1.jpg");
            }
            else
            {
                this.button1.Image = Image.FromFile("C:\\Users\\Evgeny\\VS Projects\\C-sharp-B\\Task4_WF_VS2015\\2.jpg");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {         
                this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                checkBox2.Checked = checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            checkBox1.Checked = checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            checkBox1.Checked = checkBox2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control control = button4.Parent;
            control.Text = "This is GroupBox";
            control.BackColor = Color.Blue;
            Form myForm = button4.FindForm();
            myForm.Text = "Form with button";
            myForm.BackColor = Color.Red;
            if (this.radioButton3.Checked)
                myForm.BackColor = this.radioButton3.BackColor;
            else if (this.radioButton4.Checked)
                myForm.BackColor = this.radioButton4.BackColor;
            else myForm.BackColor = this.radioButton5.BackColor;
            foreach (Control b in this.groupBox3.Controls)
            {
                // this.textBox2.AppendText(b.ToString());
                if (((RadioButton)b).Checked)
                    control.BackColor = ((RadioButton)b).BackColor;
            }
        }
    }
}
