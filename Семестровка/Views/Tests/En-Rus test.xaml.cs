using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
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
    public partial class En_Rus_test : UserControl, INotifyPropertyChanged
    {
        readonly string filePath = @"..\..\..\Files\Слова.txt";

        bool[] answers;
        string[] testingWords;

        private int _counter;
        public int Counter { 
            get { return _counter; }
            set { _counter = value; OnPropertyChanged(); }
        }

        private string _enWord;
        public string EnWord {
            get { return _enWord; }
            set { _enWord = value; OnPropertyChanged(); }
        }

        private string rightAnswer;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public En_Rus_test() {
            InitializeComponent();
            Counter = 0;
            testingWords = ReadWords();
            answers = new bool[15];
            TestMethod();
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
            if(Counter <= 15){
                if (inputWordTB.Text.ToLower() == rightAnswer)
                    answers[Counter - 1] = true;
                else answers[Counter - 1] = false;
                inputWordTB.Text = "";
                TestMethod();            
            }
            else {

            }
        }

        /// <summary>
        /// Тестирование
        /// </summary>
        void TestMethod() {
            if(testingWords != null) {
                string[] word = testingWords[Counter].Split(":", StringSplitOptions.RemoveEmptyEntries); 
                EnWord = word[0];
                rightAnswer = word[1];
                Counter++;
            }
        }

        /// <summary>
        /// Считать все слова из файла
        /// </summary>
        /// <returns></returns>
        string[] ReadWords() {
            string[] wordList = null;
            using(StreamReader sr = new StreamReader(filePath)) {
                string str = sr.ReadToEnd();
                wordList = str.Split(";\r\n", StringSplitOptions.RemoveEmptyEntries);
            }
            if(wordList != null) {
                string[] wordsForTest = FillTestArray(wordList);
                return wordsForTest;
            }
            else return null;
        }

        /// <summary>
        /// Заполинть массив 15 слов рандомно
        /// </summary>
        /// <param name="arrayElements"></param>
        /// <returns></returns>
        string[] FillTestArray(string[] arrayElements) {
            Random rnd = new Random();
            string[] array = new string[15];
            for (int i = 0; i < 15; i++) {
                int index = rnd.Next(0, arrayElements.Length);
                array[i] = arrayElements[index];
            }
            return array;
        }
    }
}
