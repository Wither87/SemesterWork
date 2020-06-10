using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Семестровка.ViewModels;

namespace Семестровка.Views.Tests
{
    /// <summary>
    /// Логика взаимодействия для TestView.xaml
    /// </summary>
    public partial class TestView : UserControl, INotifyPropertyChanged
    {
        TestViewModel tvm;
        private bool language;

        private int _counter;
        public int Counter {
            get { return _counter; }
            set { _counter = value; OnPropertyChanged(); }
        }

        private string _questionWord;
        public string QuestionWord {
            get { return _questionWord; }
            set { _questionWord = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private void InMenu_Click(object sender, RoutedEventArgs e) {
            Application.Current.MainWindow.DataContext = new TestingYourselfView();
        }

        /// <summary>
        /// Кнопка Далее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinueButton_Click(object sender, RoutedEventArgs e) {
            string answerWord = inputWordTB.Text.ToLower();
            tvm.NextQuestion(answerWord);
            Counter = tvm.Counter;
            QuestionWord = tvm.QuestionWord;
            inputWordTB.Text = tvm.TextBoxText;
        }

        public TestView(bool language) {
            InitializeComponent();
            this.language = language;
        }

        private void TestView_Loaded(object sender, RoutedEventArgs e) {
            tvm = new TestViewModel(language);
            Counter = tvm.Counter;
            QuestionWord = tvm.QuestionWord;
        }
    }
}
