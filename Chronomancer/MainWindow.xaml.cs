using System.Windows;
using System.Windows.Media.Animation;

namespace Chronomancer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            Duration duration = new Duration(TimeSpan.FromMilliseconds(500));
            CubicEase ease = new CubicEase { EasingMode = EasingMode.EaseOut };
            double targetColumnWidth = Application.Current.MainWindow.Width / 4;

            DoubleAnimation animation = new DoubleAnimation();
            animation.EasingFunction = ease;
            animation.Duration = duration;
            storyboard.Children.Add(animation);
            animation.From = 0;
            animation.To = targetColumnWidth;
            animation.FillBehavior = FillBehavior.Stop; // Otherwise the animation continues to override the value

            // Change the values before the animation, they will be restored after the animation
            Column3.MaxWidth = double.PositiveInfinity;
            Column4.MaxWidth = double.PositiveInfinity;

            Storyboard.SetTarget(animation, Column3);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(ColumnDefinition.MaxWidth)"));
            storyboard.Begin();
            Storyboard.SetTarget(animation, Column4);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(ColumnDefinition.MaxWidth)"));
            storyboard.Begin();
        }

        private void Animation_Completed(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            Duration duration = new Duration(TimeSpan.FromMilliseconds(500));
            CubicEase ease = new CubicEase { EasingMode = EasingMode.EaseOut };
            double targetColumnWidth = Application.Current.MainWindow.Width / 6;

            DoubleAnimation animation = new DoubleAnimation();
            animation.EasingFunction = ease;
            animation.Duration = duration;
            storyboard.Children.Add(animation);
            animation.From = 0;
            animation.To = targetColumnWidth;
            animation.FillBehavior = FillBehavior.Stop; // Otherwise the animation continues to override the value

            // Change the values before the animation, they will be restored after the animation
            Column5.MaxWidth = double.PositiveInfinity;
            Column6.MaxWidth = double.PositiveInfinity;

            Storyboard.SetTarget(animation, Column5);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(ColumnDefinition.MaxWidth)"));
            storyboard.Begin();
            Storyboard.SetTarget(animation, Column6);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(ColumnDefinition.MaxWidth)"));
            storyboard.Begin();
        }
    }
}