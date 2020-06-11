using System.Windows;

namespace LoginRegister
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Login = tLogin.Text,
                Email = tEmail.Text,
                Passwd = tLogin.Text
            };
        }
    }
}
