using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Chronomancer
{
    public partial class MainWindow : Window
    {
        // For Grid Column animation
        private readonly Storyboard _gridColumnStoryboard = new Storyboard();
        private readonly Duration _gridColimnAnimationDuration = new Duration(TimeSpan.FromMilliseconds(300));
        private readonly DoubleAnimation _gridColumnAnimation = new DoubleAnimation();

        public MainWindow()
        {
            InitializeComponent();
            InitializeGridColumnAnimation();
        }

        private void InitializeGridColumnAnimation()
        {
            _gridColumnAnimation.Duration = _gridColimnAnimationDuration;
            _gridColumnAnimation.From = 0;
            _gridColumnAnimation.FillBehavior = FillBehavior.Stop; // Otherwise the animation continues to override the value

            _gridColumnStoryboard.Children.Add(_gridColumnAnimation);
            Storyboard.SetTargetProperty(_gridColumnAnimation, new PropertyPath("(ColumnDefinition.MaxWidth)"));
        }

        private void AddSecondAreaButton_Click(object sender, RoutedEventArgs e)
        {
            _gridColumnAnimation.To = Application.Current.MainWindow.ActualWidth / 4;
            AnimateColumns(Column3, Column4);

            AddSecondAreaButton.Visibility = Visibility.Collapsed;
        }
        private void AddThirdAreaButton_Click(object sender, RoutedEventArgs e)
        {
            _gridColumnAnimation.To = Application.Current.MainWindow.ActualWidth / 6;
            AnimateColumns(Column5, Column6);

            AddThirdAreaButton.Visibility = Visibility.Collapsed;
        }

        private void AnimateColumns(ColumnDefinition column1, ColumnDefinition column2)
        {
            Storyboard.SetTarget(_gridColumnAnimation, column1);
            _gridColumnStoryboard.Begin();
            Storyboard.SetTarget(_gridColumnAnimation, column2);
            _gridColumnStoryboard.Begin();

            column1.MaxWidth = double.PositiveInfinity;
            column2.MaxWidth = double.PositiveInfinity;
        }

        private void Cancel1_Click(object sender, RoutedEventArgs e)
        {
            Column3.MaxWidth = 0;
            Column4.MaxWidth = 0;
            Column5.MaxWidth = 0;
            Column6.MaxWidth = 0;
            AddSecondAreaButton.Visibility = Visibility.Visible;
            AddThirdAreaButton.Visibility = Visibility.Visible;
        }

        private void Cancel2_Click(object sender, RoutedEventArgs e)
        {
            Column5.MaxWidth = 0;
            Column6.MaxWidth = 0;
            AddThirdAreaButton.Visibility = Visibility.Visible;
        }

    }
}