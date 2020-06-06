using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorPicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<UserColor> listUc = new ObservableCollection<UserColor>();
        public MainWindow()
        {
            InitializeComponent();
            list.ItemsSource = listUc;
            sRed.IsEnabled = sAlpha.IsEnabled = sGreen.IsEnabled = sBlue.IsEnabled = false;
        }

        private void sAlpha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            btnAdd.IsEnabled = true;
            Slider slider = sender as Slider;
            btnColor.Background = new SolidColorBrush(Color.FromArgb((byte)sAlpha.Value, (byte)sRed.Value, (byte)sGreen.Value, (byte)sBlue.Value));
            CheckToEqColor();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            UserColor uc = new UserColor();
            uc.ColorName = btnColor.Background.ToString();
            uc.ColorRGB = btnColor.Background;
            listUc.Add(uc);
            CheckToEqColor();
        }

        private void CheckToEqColor()
        {
            if (list.Items != null)
            {
                foreach (UserColor item in listUc)
                {
                    if (btnColor.Background.ToString() == item.ColorName)
                    {
                        btnAdd.IsEnabled = false;
                        break;
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            foreach (UserColor item in listUc)
            {
                if (btn.Tag.ToString() == item.ColorName)
                {
                    listUc.Remove(item);
                    break;
                }
            }
        }

        private void Red_Checked(object sender, RoutedEventArgs e) => SliderEnabledTrue(sRed);
        private void Green_Checked(object sender, RoutedEventArgs e) => SliderEnabledTrue(sGreen);
        private void Alpha_Checked(object sender, RoutedEventArgs e) => SliderEnabledTrue(sAlpha);
        private void Blue_Checked(object sender, RoutedEventArgs e) => SliderEnabledTrue(sBlue);
        private void SliderEnabledTrue(Slider slid) => slid.IsEnabled = true;

        private void Alpha_Unchecked(object sender, RoutedEventArgs e) => SliderEnabledFalse(sAlpha);
        private void Red_Unchecked(object sender, RoutedEventArgs e) => SliderEnabledFalse(sRed);
        private void Green_Unchecked(object sender, RoutedEventArgs e) => SliderEnabledFalse(sGreen);
        private void Blue_Unchecked(object sender, RoutedEventArgs e) => SliderEnabledFalse(sBlue);
        private void SliderEnabledFalse(Slider slid)
        {
            slid.IsEnabled = false;
            slid.Value = 0;
        }
    }
}
