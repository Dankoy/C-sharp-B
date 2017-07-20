using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // List<MyType> arrlist = new List<MyType>(); - parametrical collection

            ArrayList arrlist = new ArrayList();
            arrlist.Add(new MyType("Name 1", "1333344"));
            arrlist.Add(new MyType("Name 2", "4547687"));
            arrlist.Add(new MyType("Name 3", "1335435"));
            arrlist.Add(new MyType("Name 4", "5654243"));

            // listBoxAr.Enabled = false; - if you want to make list unable
            listBoxAr.DataSource = arrlist;     // Binding the compontnt with sourse
            listBoxAr.DisplayMember = "Name";   // Show the pointing value
            listBoxAr.ValueMember = "Phone";    // value that will be given to you as value of list
        }

        private void listBoxAr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAr.SelectedIndex != -1)  // Does this element exist?
            {
                textBox1.Text = listBoxAr.SelectedValue.ToString();
                string s = ((MyType)listBoxAr.SelectedItem).Name;
                textBox2.Text = s;
            }
        }
    }
}
