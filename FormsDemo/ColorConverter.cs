using System;
using System.Globalization;

namespace FormsDemo
{
    public class ColorConverter :
        Xamarin.Forms.IValueConverter
    {
        public ColorConverter()
        {
        }

        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (value is double) {
                var dblValue =
                    (double)value;
                var color =
                    Xamarin.Forms.Color
                           .FromHsla(
                               dblValue / 360.0,
                               1.0, 0.5, 1.0
                            );
                return color;
            }
            throw new
                System.ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
