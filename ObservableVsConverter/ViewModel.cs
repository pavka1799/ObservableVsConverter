using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ObservableVsConverter
{
    public class ViewModel
    {
        private readonly ObservableCollection<LineItem> _linesRW;
        public ObservableCollection<LineItem> LinesRW { get { return _linesRW; } }

        private readonly ReadOnlyObservableCollection<LineItem> _linesRO;
        public ReadOnlyObservableCollection<LineItem> LinesRO { get { return _linesRO; } }

        public ViewModel()
        {
            _linesRW = new ObservableCollection<LineItem>();
            _linesRO = new ReadOnlyObservableCollection<LineItem>(_linesRW);
        }


    }
}
