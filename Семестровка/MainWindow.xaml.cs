using System.Windows;
using Семестровка.ViewModels;
using Семестровка.Views;

namespace Семестровка
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void wind_Loaded(object sender, RoutedEventArgs e) {
            new MainWindowViewModel().CheckFileAndDirectory();
        }

        private void AddWord_Selected(object sender, RoutedEventArgs e) {
            wind.DataContext = new AddWordView();
        }

        private void TestingYourself_Selected(object sender, RoutedEventArgs e) {
            wind.DataContext = new TestingYourselfView();
        }

        private void WordList_Selected(object sender, RoutedEventArgs e) {
            wind.DataContext = new WordListView();
        }

        private void ResultTest_Selecred(object sender, RoutedEventArgs e) {
            wind.DataContext = new TestResultView();
        }
    }
}
