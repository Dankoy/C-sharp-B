using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _3_ApplicationProperties
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            t2.Text = Application.Current.Properties["p1"].ToString() + "\r\n";
            t2.AppendText(Application.Current.Properties["p2"].ToString());
        }

        private void Window1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }
    }
}
