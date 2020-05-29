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
        bool eqwal = false;
        bool point = false;

        double a;
        double b;
        double res;
        public MainWindow()
        {
            InitializeComponent();
            lbHistory.Content = "";
            tmp = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbLeter.Text == "0")
                tmp = "";
            Button btn = sender as Button;
            if (btn.Content.ToString() == "," && tbLeter.Text.Contains(",") == false)
            {
                if (tmp == "")
                    tmp = "0";
                tmp += btn.Content;
                btnPoint.IsEnabled = false;
            }
            else if (btn.Content.ToString() == "CE")
                tmp = "0";
            else if (btn.Content.ToString() == "C")
            {
                tmp = "0";
                a = 0;
                b = 0;
                res = 0;
                lbHistory.Content = " ";
                btnMinus.IsEnabled = true;
                btnDivide.IsEnabled = true;
                btnPlus.IsEnabled = true;
                btnMulty.IsEnabled = true;
                btnPoint.IsEnabled = true;
            }
            else if (btn.Content.ToString() == ">")
            {
                if(tbLeter.Text!="0")
                   tmp = tmp.Remove(tmp.Length - 1, 1);
                if (tmp == "")
                    tmp = "0";
            }


            else
                tmp += btn.Content;
            tbLeter.Text = tmp;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            lbHistory.Content += tmp + btnPlus.Content.ToString();
            if (plus == false && eqwal==true)
            {
                tmp = tbLeter.Text;
                lbHistory.Content = "";
                lbHistory.Content += tmp + btnPlus.Content.ToString();
                a = Convert.ToDouble(tmp);
            }
            else
                a += Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
            plus = true;
            btnDivide.IsEnabled = false;
            btnMinus.IsEnabled = false;
            btnMulty.IsEnabled = false;
            btnPoint.IsEnabled = true;

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            lbHistory.Content += tmp + btnMinus.Content.ToString();
            if (minus == false && eqwal == false)
                a = Convert.ToDouble(tmp);
            else if(minus == false && eqwal == true)
            {
                tmp = tbLeter.Text;
                lbHistory.Content = "";
                lbHistory.Content += tmp + btnMinus.Content.ToString();
                a = Convert.ToDouble(tmp);
            }else
                a -= Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
            minus = true;
            btnDivide.IsEnabled = false;
            btnPlus.IsEnabled = false;
            btnMulty.IsEnabled = false;
            btnPoint.IsEnabled = true;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            lbHistory.Content += tmp + btnDivide.Content.ToString();
            if (divide == false && eqwal == false)
                a = Convert.ToDouble(tmp);
            else if (divide == false && eqwal == true)
            {
                tmp = tbLeter.Text;
                lbHistory.Content = "";
                lbHistory.Content += tmp + btnDivide.Content.ToString();
                a = Convert.ToDouble(tmp);
            }
            else
                a /= Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
            divide = true;
            btnMinus.IsEnabled = false;
            btnPlus.IsEnabled = false;
            btnMulty.IsEnabled = false;
            btnPoint.IsEnabled = true;
        }

        private void Multy_Click(object sender, RoutedEventArgs e)
        {
            lbHistory.Content += tmp + btnMulty.Content.ToString();
            if (multupiy == false && eqwal == false)
                a = Convert.ToDouble(tmp);
            else if (multupiy == false && eqwal == true)
            {
                tmp = tbLeter.Text;
                lbHistory.Content = "";
                lbHistory.Content += tmp + btnMulty.Content.ToString();
                a = Convert.ToDouble(tmp);
            }
            else
                a *= Convert.ToDouble(tmp);
            tbLeter.Text = a.ToString();
            tmp = "";
            multupiy = true;
            btnDivide.IsEnabled = false;
            btnPlus.IsEnabled = false;
            btnMinus.IsEnabled = false;
            btnPoint.IsEnabled = true;
        }

        private void Res_Click(object sender, RoutedEventArgs e)
        {
            lbHistory.Content += tbLeter.Text + "=";
            Eqwal();
            btnDivide.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnMinus.IsEnabled = true;
            btnMulty.IsEnabled = true;
            if (tbLeter.Text.Contains(",") == true)
                btnPoint.IsEnabled = false;
            else
                btnPoint.IsEnabled = true;
        }

        private void Eqwal()
        {
            eqwal = true;
            tmp = tbLeter.Text;
            b = Convert.ToDouble(tmp);
            tmp = "";
            if (plus == true)
            {
                res = a + b;
                plus = false;
            }
            if (minus == true)
            {
                res = a - b;
                minus = false;
            }
            if (multupiy == true)
            {
                res = a * b;
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
                    res = a / b;
                divide = false;
            }
            tbLeter.Text = res.ToString();
           
        }
    }
}
