﻿using System;
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
            String queryS = "select f1, f2, f3 from Table_1";
   //         string cS = "Provider=SQLNCLI11;Data Source=EVGENY-PC;Integrated Security=SSPI;Initial Catalog=Mydb";
            // Data Source=localhost;Initial Catalog=Mydb;Integrated Security=True
            // Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Mydb
            string cS = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog=Mydb";                //"Data Source=PRAC-WIN10;Initial Catalog=Mydb;Integrated Security=True";
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