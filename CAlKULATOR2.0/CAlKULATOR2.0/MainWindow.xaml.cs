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

namespace CAlKULATOR2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string tmp = " ";
        bool plus = false;
        bool minus = false;
        bool multupiy = false;
        bool divide = false;

        double a = 0;
        double b = 0;
        double res = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        
    }
}
