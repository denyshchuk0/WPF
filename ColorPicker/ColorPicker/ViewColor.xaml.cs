using System.Windows;
using System.Windows.Controls;

namespace ColorPicker
{
    /// <summary>
    /// Логика взаимодействия для Page.xaml
    /// </summary>
    public partial class Page : UserControl
    {
        public static readonly DependencyProperty UserColorProperty = DependencyProperty.Register("UserColor", typeof(UserColor),
                                                                            typeof(Page), new PropertyMetadata(null, SetUserColor));
        private static void SetUserColor(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Page control = d as Page;
            control.lbColorName.Content = (e.NewValue as UserColor).ColorName;
            control.lbColor.Background = (e.NewValue as UserColor).ColorRGB;
        }
        public Page()
        {
            InitializeComponent();
        }
        public UserColor UserColor
        {
            get
            {
                return (UserColor)GetValue(UserColorProperty);
            }
            set
            {
                SetValue(UserColorProperty, value);
            }
        }
    }
}
