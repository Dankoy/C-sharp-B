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
using Microsoft.Win32;
using System.Collections;
using System.Windows.Forms;

namespace _5_SelfMade
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.text1.Text = this.chooseDirectory();
            this.text2.Text = this.chooseDirectory();
        }

        public string chooseDirectory()
        {
            string s = "";
            FolderBrowserDialog chooser = new FolderBrowserDialog();
            DialogResult result = chooser.ShowDialog();
            Console.WriteLine("meme " + result.GetType());
            if (result.ToString().Equals("OK"))
            {
                s = chooser.SelectedPath;
            }
            return s;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IEnumerable files1 = Directory.EnumerateFiles(this.text1.Text)
                .Select(path => System.IO.Path.GetFileName(path))
                .ToArray();
            IEnumerable files2 = Directory.EnumerateFiles(this.text2.Text)
                .Select(path => System.IO.Path.GetFileName(path))
                .ToArray();
            this.field1.ItemsSource = files1;
            this.field2.ItemsSource = files2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //файлы из первой директории, которые есть во второй
            ArrayList collection1 = filterLists(this.field1.Items, this.field2.Items);
            //файлы из второй директории, которые есть во первой
            ArrayList collection2 = filterLists(this.field2.Items, this.field1.Items);

            //файлы из 1-й директории, которые более старые чем их тезки во второй
            this.field3.ItemsSource = filterDates(collection1, text1.Text, text2.Text);
            //файлы из 2-й директории, которые более старые чем их тезки в первой
            this.field4.ItemsSource = filterDates(collection2, text2.Text, text1.Text);
        }

        private ArrayList filterLists(ItemCollection items1, ItemCollection items2)
        {

            ArrayList result = new ArrayList();
            foreach (string item in items1.SourceCollection)
            {
                if (items2.Contains(item.ToString()))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        private ArrayList filterDates(ArrayList items, string pathFrom, string pathTo)
        {
            ArrayList result = new ArrayList();
            foreach (string item in items)
            {
                if (File.GetCreationTime(pathFrom + item).Ticks < File.GetCreationTime(pathTo + item).Ticks)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            copyFiles(this.field3.ItemsSource, this.text1.Text, this.text2.Text);
            copyFiles(this.field4.ItemsSource, this.text2.Text, this.text1.Text);
        }

        private void copyFiles(IEnumerable copyList, string fromDir, string toDir)
        {
            foreach (string filename in copyList)
            {
                Console.WriteLine("from: " + fromDir + filename);
                Console.WriteLine("to: " + toDir + filename);
                File.Copy(fromDir + filename, toDir + filename, true);
                this.field3.Items.Clear();
                this.field4.Items.Clear();
                Console.WriteLine("done");
            }
        }
    }
}
