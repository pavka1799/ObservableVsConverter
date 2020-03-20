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

        private DateTime _dateOne;
        public DateTime DateOne
        {
            get { return _dateOne; }
            set
            {
                if (_dateOne != value)
                {
                    _dateOne = value;
                    NotifyPropertyChanged(nameof(DateOne));
                } 
            }
        }

        private decimal _cost;
        public decimal Cost
        {
            get { return _cost; }
            set
            {
                if (_cost != value)
                {
                    _cost = value;
                    NotifyPropertyChanged(nameof(Cost));
                }
            }
        }


    }
}
