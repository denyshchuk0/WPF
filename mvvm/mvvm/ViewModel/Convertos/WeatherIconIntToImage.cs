using System;
using System.Globalization;
using System.Windows.Data;

namespace mvvm.ViewModel.Convertos
{
    public class WeatherIconIntToImage : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string url = "";
            int namberIcon = Convert.ToInt32(value);
            url = $"../img/{namberIcon}.png";
            return url;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
