using System.Globalization;
using System.Windows.Data;

namespace Chronomancer
{
    public class MaxHeightConverter : IValueConverter
    {
        // Returns the product of @value = number of elements and @parameter = max height of one element
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is int && parameter is double)
            {
                return (int)value * (double)parameter;
            }
            else
            {
                Console.WriteLine("ERROR: MaxHeightConverter called with incorrect type of value or parameter");
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        
    }
}
