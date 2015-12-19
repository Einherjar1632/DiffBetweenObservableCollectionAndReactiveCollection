using System;
using System.Collections.Generic;
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

namespace DiffBetweenObservableCollectionAndReactiveCollection
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowViewModel();
            this.DataContext = vm;
        }

        private void ObservableCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            vm.AddObservableCollection();
        }

        private void ReactiveCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            vm.AddReactiveCollection();
        }
    }
}
