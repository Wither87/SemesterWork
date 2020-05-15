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
using Семестровка;
using Семестровка.Views.Tests;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для TestingYourselfView.xaml
    /// </summary>
    public partial class TestingYourselfView : UserControl
    {
        public TestingYourselfView()
        {
            InitializeComponent();
        }

        private void En_Rus_TestCkick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.DataContext = new En_Rus_test();
        }

        private void Rus_En_TestClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.DataContext = new Rus_En_test();
        }
    }
}
