using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Семестровка.Views.Tests
{
    /// <summary>
    /// Логика взаимодействия для En_Rus_test.xaml
    /// </summary>
    public partial class En_Rus_test : UserControl
    {
        public En_Rus_test() {
            InitializeComponent();
        }

        private void InMenu_Click(object sender, RoutedEventArgs e) {
            Application.Current.MainWindow.DataContext = new TestingYourselfView();
        }
    }
}
