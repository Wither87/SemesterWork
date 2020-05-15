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
using Семестровка.ViewModels;
using System.IO;

namespace Семестровка
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly string directoryPath = @"..\..\..\Files";
        readonly string filePath = @"..\..\..\Files\Слова.txt";

        public MainWindow()
        {
            InitializeComponent();
            CheckFileAndDirectory();
        }

        void CheckFileAndDirectory() {
            if (!Directory.Exists(directoryPath)) {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath)) {
                File.Create(filePath);
            }
        }

        private void AddWord_Selected(object sender, RoutedEventArgs e)
        {
            wind.DataContext = new AddWordViewModel();
        }

        private void TestingYourself_Selected(object sender, RoutedEventArgs e)
        {
            wind.DataContext = new TestingYourselfViewModel();
        }

        private void WordList_Selected(object sender, RoutedEventArgs e)
        {
            wind.DataContext = new WordListViewModel();
        }
    }
}
