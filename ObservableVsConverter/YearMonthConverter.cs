using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ObservableVsConverter
{
    public class YearMonthConverter : IValueConverter
    {
        // This converter changes the value of a Tasks Complete status from true/false to a string value of
        // "Complete"/"Active" for use in the row group header.
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((DateTime)value).ToString("yyyy/MM");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
