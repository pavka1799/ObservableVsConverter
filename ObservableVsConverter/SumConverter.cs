using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ObservableVsConverter
{
    public class SumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == DependencyProperty.UnsetValue) return DependencyProperty.UnsetValue;
            if (null == parameter) return null;
            string propertyName = (string)parameter;
            //System.Collections.ObjectModel.ReadOnlyObservableCollection<object> collection = (System.Collections.ObjectModel.ReadOnlyObservableCollection<object>)value;

            //CollectionViewGroup cvg = (CollectionViewGroup)value;
            //ReadOnlyObservableCollection<object> collection = cvg.Items;
            if (!(value is ReadOnlyObservableCollection<object>)) return null;
            ReadOnlyObservableCollection<object> collection = (ReadOnlyObservableCollection<object>)value;
            //if (null == collection) return null;
            //if (0 == collection.Count) return null;
            //CollectionViewGroup cvg = (CollectionViewGroup)collection[0];
            decimal sum = 0;
            // Double field
            foreach (object o in collection)
            {
                sum += (decimal)o.GetType().GetProperty(propertyName).GetValue(o);
            }
            return sum;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
