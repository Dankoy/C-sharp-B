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
using Word = Microsoft.Office.Interop.Word;

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

        public void Display(IEnumerable<Price> accounts, Action<Price, Excel.Range> DisplayFunc)
        {
            excelApp.Cells[2, 1].Select();
            foreach (var ac in accounts)
            {
                DisplayFunc(ac, excelApp.ActiveCell);
                excelApp.ActiveCell.Offset[1, 0].Select();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Accounts = new List<Price>
            {
                new Price {ID = 100, Val = 123.25 },
                new Price {ID = 200, Val = -155.65}
            };

            Display(Accounts, (account, cell) =>
            {
                // многострочная лямбда определяет правило отображения значений
                cell.Value = account.ID;
                cell.Offset[0, 1].Value = account.Val;

                if (account.Val < 0)
                {
                    cell.Interior.Color = 255;
                    cell.Offset[0, 1].Interior.Color = 255;
                }
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            excelApp.Range["A1:B3"].Copy();
            var word = new Word.Application();
            word.Visible = true;
            word.Documents.Add();
            word.Selection.PasteSpecial(Link: true, DisplayAsIcon: true);
        }
    }
}
