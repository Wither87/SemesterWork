using System.Windows;
using System.Windows.Controls;
using Семестровка.ViewModels;
using Семестровка.Views.Tests;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для TestingYourselfView.xaml
    /// </summary>
    public partial class TestingYourselfView : UserControl
    {
        public TestingYourselfView() {
            InitializeComponent();
        }

        private void En_Rus_TestCkick(object sender, RoutedEventArgs e) {
            Application.Current.MainWindow.DataContext = new TestView(true);
        }

        private void Rus_En_TestClick(object sender, RoutedEventArgs e) {
            Application.Current.MainWindow.DataContext = new TestView(false);
        }

        private void TestingYourselfView_Loaded(object sender, RoutedEventArgs e) {
            new TestingYourselfViewModel(selectGrid);
        }
    }
}
