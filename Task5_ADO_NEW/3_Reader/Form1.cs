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

namespace _3_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String queryS = "select f1, f2 from Table_1";
            string cS = "Provider=SQLNCLI11;Data Source=EVGENY-PC;Integrated Security=SSPI;Initial Catalog=Mydb";
            using (OleDbConnection con = new OleDbConnection(cS))
            {
                OleDbCommand cmd = new OleDbCommand(queryS, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                    Console.Write(" ");
                    Console.WriteLine(reader[1].ToString());
                }
                reader.Close();
            }
        }
    }
}
