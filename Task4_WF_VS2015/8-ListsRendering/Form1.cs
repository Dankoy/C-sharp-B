using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_ListsRendering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            switch (e.Index)
            {
                case 0:
                    myBrush = Brushes.Red;
                    break;
                case 1:
                    myBrush = Brushes.Orange;
                    break;
                case 2:
                    myBrush = Brushes.Purple;
                    break;
            }
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void InitializeOwnerDrawnListBox()
        {
            this.listBox2 = new System.Windows.Forms.ListBox();
            listBox2.Location = new Point(20, 20);
            listBox2.Size = new Size(240, 240);
            this.listBox2.Items.AddRange(new object[]
            { "System.Windows.Forms",
                "System.Drawning",
                "System.Xml",
                "System.Net",
                "System.Runtime.Remoting",
                "System.Web"
            });
            listBox2.ScrollAlwaysVisible = false;
            listBox2.BorderStyle = BorderStyle.FixedSingle;
            listBox2.DrawMode = DrawMode.OwnerDrawVariable;
            listBox2.MeasureItem += new MeasureItemEventHandler(listBox2_MeasureItem);
            listBox2.DrawItem += new DrawItemEventHandler(listBox2_DrawItem);
            this.Controls.Add(this.listBox2);

        }

        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
            }

            e.Graphics.DrawRectangle(Pens.Blue, e.Bounds);
            e.Graphics.DrawString(listBox2.Items[e.Index].ToString(),
                this.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
            e.DrawFocusRectangle();
        }

        private void listBox2_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox b = (ListBox)sender;
            string itemString = (string)b.Items[e.Index];
            string[] resultString = itemString.Split('.');
            if (resultString.Length > 2) { e.ItemHeight += 10; }
            else { e.ItemHeight += 5; }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
