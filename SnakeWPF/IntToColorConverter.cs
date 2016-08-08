using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace SnakeWPF
{
    public class IntToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (System.Convert.ToInt32(value))
            {
                case 0:
                    return Brushes.White;
                case 3:
                    return Brushes.OrangeRed;
                case 1:
                    return Brushes.Black;
                default:
                    return Brushes.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
