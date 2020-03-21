using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObservableVsConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();

            _vm = (ViewModel)Resources["VM"];

            _vm.LinesRW.Add(new LineItem(new DateTime(2020, 1, 1), 100));
            _vm.LinesRW.Add(new LineItem(new DateTime(2020, 2, 2), 70));
        }

        private int _i = 3;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            _vm.LinesRW.Add(new LineItem(new DateTime(2020, 3, 3), _i++));
        }

    }
}
