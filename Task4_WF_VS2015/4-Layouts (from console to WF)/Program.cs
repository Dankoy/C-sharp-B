using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Layouts__from_console_to_WF_
{
    public partial class Form1 : Form
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        public Form1()
        {
            Text = "Flow Panel Alignment";
            FlowLayoutPanel flow = new FlowLayoutPanel();    // Плавающая компановка
            flow.Parent = this;
            flow.Dock = DockStyle.Fill;
            flow.Text = "Flow Panel";
            flow.Click += ClickHandler;
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Parent = flow;
                btn.Text = "Button " + (i + 1);
                btn.Click += ClickHandler;                   // Добавляем обработку события Click
                                                             // Устанавливаем случайный размер элемента управления
                Size sz = btn.PreferredSize;
                sz.Width = (int)(sz.Width * (1 + 2 * rand.NextDouble()));
                sz.Height = (int)(sz.Height * (1 + 2 * rand.NextDouble()));
                btn.Size = sz;
            }

        }

        void ClickHandler(object objSrc, EventArgs args)     // Обработчик события
        {
            Control Ctrl = (Control)objSrc;                  // Объект для которого произошло событие
            Form frm = new Form();
            frm.Text = Ctrl.Text;
            frm.Owner = this;
            PropertyGrid prop = new PropertyGrid();          // Окно свойств 
            prop.SelectedObject = objSrc;
            prop.Parent = frm;                               // Определение родительской формы
            prop.Dock = DockStyle.Fill;                      // Заполнение всей клиентской области формы
            frm.Show();                                      // Отображение формы

        }
    }
}
