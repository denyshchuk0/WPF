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

namespace CatalogMVVM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lang_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("Properties/" + (sender as MenuItem).Tag + ".xaml", UriKind.Relative);
            MenuItem header = (sender as MenuItem).Parent as MenuItem;

            foreach (var item in header.Items)
            {
                (item as MenuItem).IsChecked = false;
            }
             (sender as MenuItem).IsChecked = !(sender as MenuItem).IsChecked;
     
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
