using Microsoft.Win32;
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
using System.Windows.Threading; 

namespace MediaPlayerWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            MediaElement.Volume = 0.5;
            MediaElement.Volume = 0.5;
            MediaElement.MediaOpened += MediaElement_MediaOpened;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Play();
            timer.Start();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Pause();
            timer.Stop();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Stop();
            timer.Stop();
            SeekSlider.Value = 0;
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (MediaElement.NaturalDuration.HasTimeSpan)
            {
                SeekSlider.Maximum = MediaElement.NaturalDuration.TimeSpan.TotalSeconds;
            }
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                MediaElement.Source = new Uri(openFileDialog.FileName);
                NowPlayingText.Text = $"Сейчас играет: {System.IO.Path.GetFileName(openFileDialog.FileName)}";
                MediaElement.Play();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (MediaElement.NaturalDuration.HasTimeSpan && MediaElement.IsLoaded)
            {
                SeekSlider.Value = MediaElement.Position.TotalSeconds;
            }
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaElement.Volume = VolumeSlider.Value;
        }

        private void SeekSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaElement.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = TimeSpan.FromSeconds(SeekSlider.Value);
                MediaElement.Position = ts;
            }
        }
    }
}

