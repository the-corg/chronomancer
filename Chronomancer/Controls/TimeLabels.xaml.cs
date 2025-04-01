using System.Windows;
using System.Windows.Controls;

namespace Chronomancer
{
    public partial class TimeLabels : UserControl
    {
        public TimeLabels()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty RightTicksProperty = DependencyProperty.Register(
            "RightTicks", typeof(bool), typeof(TimeLabels));
        public static readonly DependencyProperty LeftTicksProperty = DependencyProperty.Register(
            "LeftTicks", typeof(bool), typeof(TimeLabels));
        public static readonly DependencyProperty TextAlignmentProperty = DependencyProperty.Register(
            "TextAlignment", typeof(HorizontalAlignment), typeof(TimeLabels));
        public required bool RightTicks { get; set; } = true;
        public required bool LeftTicks { get; set; } = false;
        public required HorizontalAlignment TextAlignment { get; set; } = HorizontalAlignment.Left;
    }
}
