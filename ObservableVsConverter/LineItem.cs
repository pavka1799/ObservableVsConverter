using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableVsConverter
{
    public class LineItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private DateTime _amountDate;
        public DateTime AmountDate
        {
            get { return _amountDate; }
            set
            {
                if (_amountDate != value)
                {
                    _amountDate = value;
                    NotifyPropertyChanged(nameof(AmountDate));
                } 
            }
        }

        private decimal _amountValue;
        public decimal AmountValue
        {
            get { return _amountValue; }
            set
            {
                if (_amountValue != value)
                {
                    _amountValue = value;
                    NotifyPropertyChanged(nameof(AmountValue));
                }
            }
        }

        public LineItem(DateTime date, decimal value)
        {
            _amountDate = date;
            _amountValue = value;
        }

    }
}
