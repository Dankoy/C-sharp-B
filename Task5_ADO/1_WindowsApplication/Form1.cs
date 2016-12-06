using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_WindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DBDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.my_DBDataSet1.Book);
            // TODO: This line of code loads data into the 'my_DBDataSet.t3' table. You can move, or remove it, as needed.
            this.t3TableAdapter.Fill(this.my_DBDataSet.t3);

            oleDbDataAdapter1.Fill(this.my_DBDataSet);

        }

        private void oleDbDataAdapter2_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
