using System.Windows;
using System.Windows.Controls;
using Семестровка.ViewModels;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для WordListView.xaml
    /// </summary>
    public partial class WordListView : UserControl {
        public WordListView() {
            InitializeComponent();
        }

        private void WordListView_Loaded(object sender, RoutedEventArgs e) {
            new WordListViewModel(listView);
        }
    }
}
