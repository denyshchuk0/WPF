using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace mvvm.ViewModel.Convertos
{
    class IsDayTimeToBackground : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush backColor;
            bool isTime = System.Convert.ToBoolean(value);
            if (isTime == false)
                backColor = new SolidColorBrush(Colors.DeepSkyBlue);
            else
                backColor = new SolidColorBrush(Colors.LightYellow);

            return backColor;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
