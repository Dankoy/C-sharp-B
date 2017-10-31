using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Reader_UNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cS = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Mydb";
            String queryS = "select f1, f2 from Table_1";
            using (OleDbConnection con = new OleDbConnection(cS))
            {
                OleDbCommand cmd = new OleDbCommand(queryS, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.AppendText(reader[0].ToString());
                    textBox1.AppendText(" ");
                    textBox1.AppendText(reader[1].ToString() + "\n");
                    
                }
                reader.Close();
            }
        }

    }
}
