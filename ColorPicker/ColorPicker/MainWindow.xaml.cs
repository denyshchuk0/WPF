using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
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

namespace ColorPicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserColor uc = new UserColor();
        ObservableCollection<UserColor> listUc = new ObservableCollection<UserColor>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sAlpha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
          
                btnColor.Background = new SolidColorBrush(Color.FromArgb((byte)sAlpha.Value, (byte)sRed.Value, (byte)sGreen.Value, (byte)sBlue.Value)); 
        }
      
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            uc.ColorName = btnColor.Background.ToString();
            uc.ColorRGB = btnColor.Background;

            listUc.Add(uc);
            uc.index++;
            list.ItemsSource = listUc;
            
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
             Button btn = sender as Button;
             MessageBox.Show(btn.Tag.ToString());
             listUc.Remove(listUc[(int)btn.Tag -1]);
             uc.index--;
        }
    }

}
