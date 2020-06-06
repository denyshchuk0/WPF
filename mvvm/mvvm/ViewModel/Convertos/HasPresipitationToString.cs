using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace mvvm.ViewModel.Convertos
{
    class HasPresipitationToString : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string precipitation = "Precipitation: ";
            bool isPrecipitation = System.Convert.ToBoolean(value);

            if (isPrecipitation)
                precipitation += "No";
            else
                precipitation += "Yes";
            return precipitation;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
