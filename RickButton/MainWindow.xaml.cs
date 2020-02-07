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
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace RickButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard meeseeksAnimation;
        Storyboard garageExitAnimation;
        Storyboard lrExitAnimation;
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            meeseeksAnimation = (Storyboard)Resources["MeeseeksAppears"];
            garageExitAnimation = (Storyboard)Resources["GarageExit"];
            lrExitAnimation = (Storyboard)Resources["LRExit"];

            mediaPlayer.Open(new Uri("..\\..\\sound\\hey.mp3", UriKind.Relative));
            mediaPlayer.Play();

            meeseeksAnimation.Completed += (s, e) =>
            {
                mediaPlayer.Open(new Uri("..\\..\\sound\\meeseeks.mp3", UriKind.Relative));
                mediaPlayer.Play();
            };

            Rick.MouseEnter += (s, e) =>
            {
                mediaPlayer.Open(new Uri("..\\..\\sound\\hey.mp3", UriKind.Relative));
                mediaPlayer.Play();
            };

            garageExitAnimation.Completed += (s, e) =>
            {
                mediaPlayer.Open(new Uri("..\\..\\sound\\im_cool_rick.mp3", UriKind.Relative));
                mediaPlayer.Play();
            };

            lrExitAnimation.Completed += (s, e) =>
            {
                mediaPlayer.Open(new Uri("..\\..\\sound\\pickle.mp3", UriKind.Relative));
                mediaPlayer.Play();
            };

        }

        
    }
}
