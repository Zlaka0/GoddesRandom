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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Reflection.Metadata.BlobBuilder;

namespace GoddesRandom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();
        private bool _isMax = false;
        public static MainWindow Window;
        public MainWindow()
        {
            InitializeComponent();
            Window = this;
            player.Open(new Uri("Audio\\Jojo_-_Ayaya_67235256.mp3", UriKind.Relative));
            player.Play();

        }
        private void MovingWindow(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MainWindow.Window.DragMove();
            }

        }

        private void Border_MouseLeftButtDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (_isMax)
                {
                    WindowState = WindowState.Normal;
                    Width = 800;
                    Height = 450;
                    _isMax = false;

                    Sound.Width = 50;
                    Sound.Height = 50;
                    Sound.Margin = new Thickness(8);


                    H1.FontSize = 28;
                    H1.Width = 650;
                    H1.Height = 60;
                    H1.Margin = new Thickness(0);


                    H2.FontSize = 24;
                    H2.Width = 280;
                    H2.Height = 40;
                    H2.Margin = new Thickness(5);
                    H2.Padding = new Thickness(5);


                    R1.FontSize = 92;
                    R1.Width = 100;
                    R1.Height = 100;
                    R1.Margin = new Thickness(40);
                    R1.Padding = new Thickness(5);


                    Go.Width = 300;
                    Go.Height = 60;
                    Go.Margin = new Thickness(30);
                    Go.FontSize = 32;


                    Blobs.HorizontalAlignment = HorizontalAlignment.Left;
                    Blobs.VerticalAlignment = VerticalAlignment.Top;
                    Blobs2.HorizontalAlignment = HorizontalAlignment.Right;
                    Blobs2.VerticalAlignment = VerticalAlignment.Bottom;
                    Balls1.VerticalAlignment = VerticalAlignment.Top;
                    Balls1.HorizontalAlignment = HorizontalAlignment.Right;
                    Balls2.HorizontalAlignment = HorizontalAlignment.Left;
                    Balls2.VerticalAlignment = VerticalAlignment.Bottom;


                    Blobs.Width = 370;
                    Blobs.Height = 200;
                    Blobs2.Width = 370;
                    Blobs2.Height = 200;
                    Balls1.Width = 200;
                    Balls1.Height = 150;
                    Balls2.Height = 200;
                    Balls2.Width = 150;


                    Balls1.Margin = new Thickness(5);
                    Balls2.Margin = new Thickness(5);

                }
                else
                {
                    WindowState = WindowState.Maximized;
                    _isMax = true;

                    Sound.Width = 80;
                    Sound.Height = 80;
                    Sound.Margin = new Thickness(20);

                    H1.FontSize = 64;
                    H1.Width = 1500;
                    H1.Height = 90;
                    H1.Margin = new Thickness(100);

                    H2.FontSize = 48;
                    H2.Width = 600;
                    H2.Height = 80;
                    H2.Margin = new Thickness(25);
                    H2.Padding = new Thickness(25);


                    R1.FontSize = 180;
                    R1.Width = 250;
                    R1.Height = 220;
                    R1.Margin = new Thickness(30);
                    R1.Padding = new Thickness(40);



                    Go.Width = 800;
                    Go.Height = 120;
                    Go.Margin = new Thickness(130);
                    Go.FontSize = 52;

                    cancelButton.HorizontalAlignment = HorizontalAlignment.Right;
                    cancelButton.VerticalAlignment = VerticalAlignment.Top;

                    Blobs.HorizontalAlignment = HorizontalAlignment.Left;
                    Blobs.VerticalAlignment = VerticalAlignment.Top;
                    Blobs2.HorizontalAlignment = HorizontalAlignment.Right;
                    Blobs2.VerticalAlignment = VerticalAlignment.Bottom;
                    Balls1.VerticalAlignment = VerticalAlignment.Top;
                    Balls1.HorizontalAlignment = HorizontalAlignment.Right;
                    Balls2.HorizontalAlignment = HorizontalAlignment.Left;
                    Balls2.VerticalAlignment = VerticalAlignment.Bottom;

                    Blobs.Width = 800;
                    Blobs.Height = 600;
                    Blobs2.Width = 800;
                    Blobs2.Height = 550;
                    Balls1.Width = 400;
                    Balls1.Height = 350;
                    Balls2.Width = 400;
                    Balls2.Height = 350;


                    Balls1.Margin = new Thickness(40);
                    Balls2.Margin = new Thickness(40);
                }

            }

        }



        private void random_1()
        {
            Random rnd = new Random();
            int a = rnd.Next(01, 27);
            R1.Text = a.ToString("D2");


            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 1;
            da.Duration = new Duration(TimeSpan.FromSeconds(1.8));



            R1.BeginAnimation(OpacityProperty, da);

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            H2.Text = "Счастливчик под номером: ";
            random_1();


        }




        private void closeButton_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }


        private void Sound_Click(object sender, RoutedEventArgs e)
        {

            player.Pause();


        }



    }
}
