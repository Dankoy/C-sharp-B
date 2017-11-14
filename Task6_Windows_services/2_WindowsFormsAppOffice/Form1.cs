using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace _2_WindowsFormsAppOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            excelApp.Visible = true;
        }

        Excel.Application excelApp;

        private void button2_Click(object sender, EventArgs e)
        {
            excelApp.Range["A1"].Value = "Столбец ID";
            excelApp.ActiveCell.Offset[1, 0].Select();

            Excel.Range R1 = excelApp.Range["B1"];
            R1.Value = "Столбец значений";


            // Autofit to text
            excelApp.Columns[1].AutoFit();
            excelApp.Columns[2].AutoFit();

            // Shows name in specified row
            System.Security.Principal.WindowsIdentity user;
            user = System.Security.Principal.WindowsIdentity.GetCurrent();
            excelApp.Range["E1"].Value = user.Name;
        }
    }
}
