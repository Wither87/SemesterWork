using System.Windows;
using System.Windows.Controls;
using Семестровка.ViewModels;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для TestResultView.xaml
    /// </summary>
    public partial class TestResultView : UserControl
    {
        public TestResultView() {
            InitializeComponent();
        }

        private void TestResultView_Loaded(object sender, RoutedEventArgs e) {
            new TestResultViewModel(firstSP, secondSP).ShowResulrs();
        }
    }
}
