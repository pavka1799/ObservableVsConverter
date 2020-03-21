using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ObservableVsConverter
{
    public class SumMulConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (null == parameter) return null;
            if (!(parameter is string)) return null;
            string propertyName = (string)parameter;

            if (values == DependencyProperty.UnsetValue) return DependencyProperty.UnsetValue;
            if (values == null) return null;
            if (values.Length < 2) return null;
            if (!(values[0] is ReadOnlyObservableCollection<object>)) return null;
            ReadOnlyObservableCollection<object> collection = (ReadOnlyObservableCollection<object>)values[0];
            if (!(values[1] is int)) return null;
            Debug.Print($"ItemCount={(int)values[1]}; Collection Count = {collection.Count}");
            decimal sum = 0;
            foreach (object o in collection)
            {
                sum += (decimal)o.GetType().GetProperty(propertyName).GetValue(o);
            }
            return sum; //.ToString("N2", CultureInfo.CurrentCulture);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
