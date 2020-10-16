using System;
using System.Collections;
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

namespace Homework_85
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(keyTxt.Text, valueTxt.Text);
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(keyTxt.Text);
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            string allData = "";
            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection)
            {
                allData = allData + "\n Key is " + key + " " + " Value is " + hashtable[key].ToString();
            }
            MessageBox.Show(allData);
        }
    }
}
