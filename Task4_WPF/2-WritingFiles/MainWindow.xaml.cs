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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace _2_WritingFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            string StartDirectory = @"C:\Users\Evgeny\VS Projects\C-sharp-B\Task4_WPF\2-WritingFiles\Copy"; //Where we copy things from
            string EndDirectory = @"C:\Users\Evgeny\VS Projects\C-sharp-B\Task4_WPF\2-WritingFiles\Paste";   //Where we copy things to
            this.t1.Clear();    // Clearing textbox1

            foreach (string filename in Directory.EnumerateFiles(StartDirectory))
            {
                this.t1.AppendText(filename + "\r\n"); //Add name of copying file in textbox
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(EndDirectory + filename.Substring(filename.LastIndexOf('\\'))))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);  // Copying file
                    }
                }
            }
        }
    }
}
