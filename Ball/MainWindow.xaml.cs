using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ball_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Thickness high = new Thickness(0, 10, 0, 0);
            Thickness low = new Thickness(0, 360, 0, 0);

            ThicknessAnimation upAnimation = new ThicknessAnimation(low, high, TimeSpan.FromSeconds(3));
            upAnimation.DecelerationRatio = 1;
            AnimationClock animationClock = upAnimation.CreateClock();
            ball.ApplyAnimationClock(MarginProperty, animationClock);

            ThicknessAnimation downAnimation = new ThicknessAnimation(low, TimeSpan.FromSeconds(2));
            downAnimation.AccelerationRatio = 1;
            ball.BeginAnimation(MarginProperty, downAnimation, HandoffBehavior.Compose);
        }
    }
}
