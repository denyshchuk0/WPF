using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Button = System.Windows.Controls.Button;
using MessageBox = System.Windows.MessageBox;

namespace CAlKULATOR2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string tmp = "";
        bool plus = false;
        bool minus = false;
        bool multupiy = false;
        bool divide = false;

        double a;
        double b;
        double res;
        public MainWindow()
        {
            InitializeComponent();
            lbHistory.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            tmp += btn.Content;
            tbLeter.Text = tmp;
        }
        //private void Operation()
        //{
        //    tmp = tbLeter.Text;
        //    a += Convert.ToDouble(tmp);
        //    tmp = "";
        //}

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            plus = true;
        
            lbHistory.Content += tmp;
            lbHistory.Content += btnPlus.Content.ToString();

            tmp = tbLeter.Text;
            a += Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            minus = true;
            lbHistory.Content += tmp;
            lbHistory.Content += btnMinus.Content.ToString();
            tmp = tbLeter.Text;
            if(a==0)
                a+= Convert.ToDouble(tmp);
            else
                a -= Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            divide = true;
            lbHistory.Content += tmp;
            lbHistory.Content += btnDivide.Content.ToString();

            tmp = tbLeter.Text;
            if (a == 0)
                a = Convert.ToDouble(tmp);
            else 
                a /= Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
        }

        private void Multy_Click(object sender, RoutedEventArgs e)
        {
            multupiy = true;
            lbHistory.Content += tmp;
            lbHistory.Content += btnMulty.Content.ToString();
     
            tmp = tbLeter.Text;
            if (a == 0)
            {
                a = 1;
            }
            a *= Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
        }

        private void Res_Click(object sender, RoutedEventArgs e)
        {
            lbHistory.Content += tbLeter.Text + "=";
            Eqwal();
        }

        private void Eqwal()
        {
            tmp = tbLeter.Text;
            b = Convert.ToDouble(tmp);
            tmp = "";
            if (plus == true)
            {
                res = a+b ;
                plus = false;
            }
            if (minus == true)
            {
                res = a-b ;
                minus = false;
            }
            if (multupiy == true)
            {
                res = a*b ;
                multupiy = false;
            }
            if (divide == true)
            {
                if (b == 0)
                {
                    MessageBox.Show("Divide by zero!!!",
                    "ERROR");
                }
                else
                    res = a/b ;
            }
            tbLeter.Text = res.ToString();
        }
    }
}
