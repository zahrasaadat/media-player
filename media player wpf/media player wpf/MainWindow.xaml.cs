using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace media_player_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///   
    public partial class MainWindow : Window
    {
      // MediaElement mediaElement;
       //MediaPlayer mediaPlayer = new MediaPlayer();
    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//play
        {
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//pause
        {
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Pause();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //stop
        {
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //add media
        {
            OpenFileDialog open = new OpenFileDialog();
            open.AddExtension = true;
            open.DefaultExt = "*.*";
            open.Filter = "Media(*.*)|*.*";
            open.ShowDialog();
         
            
                    String fileName = open.FileName;
                    mediaElement.Source = new Uri(fileName);

            
        }
    }
}
