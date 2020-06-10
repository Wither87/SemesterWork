using System.Windows;
using System.Windows.Controls;
using Семестровка.ViewModels;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для AddWordView.xaml
    /// </summary>
    public partial class AddWordView : UserControl {
        public AddWordView() {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            var awvm = new AddWordViewModel { EnWord = enTB.Text, RuWord = ruTB.Text };
            awvm.WriteInFile();
            enTB.Text = awvm.EnWord;
            ruTB.Text = awvm.RuWord;
        }
    }

    
}
