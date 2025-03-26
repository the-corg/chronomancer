using System.Globalization;
using System.Windows.Data;

namespace Chronomancer
{
    public class MaxHeightConverter : IValueConverter
    {
        // Returns the product of @value = number of elements and @parameter = max height of one element
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is not int || parameter is not double)
                return 0;

            return (int)value * (double)parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }
}
