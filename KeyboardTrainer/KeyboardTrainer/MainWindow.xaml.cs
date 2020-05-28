using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Color_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key.ToString() == tb.Text)
                tb.Text = "0";
        }
    }
}