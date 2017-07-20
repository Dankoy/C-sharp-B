using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MultiSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Column 1";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 146;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Column 2";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 142;

            this.listView1.Columns.Add(columnHeader1);
            this.listView1.Columns.Add(columnHeader2);

            string[] foodList = new string[] { "Сок", "Молоко", "Кофе", "Чай", "Кекс", "Пирожное" };
            string[] foodPrice = new string[] { "20.00", "100.00", "25.00", "5.00", "15.00", "35.00" };
            for (int count = 0; count < foodList.Length; count++)
            {
                ListViewItem listitem = new ListViewItem(foodList[count]);
                listitem.SubItems.Add(foodPrice[count]);
                listView1.Items.Add(listitem);
            }
        }
    }
}
