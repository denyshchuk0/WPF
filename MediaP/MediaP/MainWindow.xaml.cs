using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace _05_Controls_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool play = false;
        DispatcherTimer timer = new DispatcherTimer();
        ObservableCollection<Uri> list = new ObservableCollection<Uri>();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_tick;
            listPlay.ItemsSource = list;
            btnPlay.ToolTip = "Play";
            btnPlayList.ToolTip = "Show all playlist";
        }
        private void timer_tick(object sender, EventArgs e)
        {
            time.Text = media.Position.ToString(@"mm\:ss");
            sTimeLips.Value = media.Position.TotalSeconds;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                media.Source = new Uri(ofd.FileName);
                media.ToolTip = media.Source.LocalPath;
                MediaPlay();
            }
        }

        private void MediaPlay()
        {
            media.Play();
            play = true;
            btnPlay.Content = "Pause";
            btnPlay.ToolTip = "Pause";
            timer.Start();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            slider.Value = media.Volume;
            if (play == false && media.Source != null)
            {
                MediaPlay();
            }
            else
            {
                media.Pause();
                play = false;
                btnPlay.Content = "Play";
                btnPlay.ToolTip = "Play";
                timer.Stop();
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e) =>
            media.Volume += 0.1;
        
        private void Minus_Click(object sender, RoutedEventArgs e) =>
            media.Volume -= 0.1;
        
        private void media_MediaOpened(object sender, RoutedEventArgs e) =>
            sTimeLips.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;

        private void sTimeLips_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)=>
            media.Position = TimeSpan.FromSeconds(sTimeLips.Value);

        bool visiblePlayList = false;
        private void btnPlayList_Click(object sender, RoutedEventArgs e)
        {
            if (visiblePlayList == false)
            {
                spList.Visibility = Visibility.Visible;
                visiblePlayList = true;
                btnPlayList.Content = "Hige playlist";
                btnPlayList.ToolTip = "Hige all playlist";
            }
            else
            {
                spList.Visibility = Visibility.Hidden;
                visiblePlayList = false;
                btnPlayList.Content = "Show playlist";
                btnPlayList.ToolTip = "Show all playlist";
            }
        }

        private void btnAddPlayList_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                list.Add(new Uri(ofd.FileName));
            }
        }

        private void listPlay_MouseDoubleClick(object sender, MouseButtonEventArgs e)=>
            media.Source = list[listPlay.SelectedIndex]; 

        private void BackTo_Click(object sender, RoutedEventArgs e)=>
            sTimeLips.Value = media.Position.TotalSeconds - 20;

        private void FrontTo_click(object sender, RoutedEventArgs e)=>
            sTimeLips.Value = media.Position.TotalSeconds + 20;

        bool sound = true;
        double sValue = 0;
        private void OnOffSound_Click(object sender, RoutedEventArgs e)
        {
            if (sound == true)
            {
                sValue = media.Volume;
                media.Volume = 0;
                slider.Value = 0;
                slider.IsEnabled = false;
                btnSoundAdd.IsEnabled = false;
                btnSoundSub.IsEnabled = false;
                btnSoundOnOff.Content = "on";
                sound = false;
            }
            else
            {
                media.Volume = sValue;
                slider.IsEnabled = true;
                btnSoundAdd.IsEnabled = true;
                btnSoundSub.IsEnabled = true;
                btnSoundOnOff.Content = "off";
                sound = true;
            }
        }
    }
}
