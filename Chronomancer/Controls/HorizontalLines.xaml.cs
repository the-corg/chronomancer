using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chronomancer
{
    public partial class HorizontalLines : UserControl
    {

        public HorizontalLines()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty LineColorProperty = DependencyProperty.Register(
            "LineColor", typeof(SolidColorBrush), typeof(HorizontalLines),
            new FrameworkPropertyMetadata(new SolidColorBrush(Colors.White), FrameworkPropertyMetadataOptions.AffectsRender));
        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register(
            "Quantity", typeof(int), typeof(HorizontalLines),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender, OnQuantityChanged));

        public required SolidColorBrush LineColor { get; set; }
        public required int Quantity { get; set; }

        private static void OnQuantityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is int quantity && d is HorizontalLines horizontalLines)
            {
                for (int i = 0; i < quantity - 2; i++)
                {
                    horizontalLines.HorizontalLinesGrid.Children.Add(new Border());
                }
                // The last border is different
                var lastBorder = new Border();
                lastBorder.Style = (Style)horizontalLines.FindResource("LastBorder");
                horizontalLines.HorizontalLinesGrid.Children.Add(lastBorder);
            }
        }
    }
}
