using System;
using System.Windows;
using Семестровка.Views;

namespace Семестровка.ViewModels
{
    class TestViewModel {
        private readonly string wordFilePath = @"Files\Слова.txt";
        private readonly string resultTestFilePath = @"Files\Результат теста.txt";

        private bool[] answers;
        private string[] testingWords;

        private bool enLanguage; // язык
        public int Counter { get; set; } // сщётчик
        public string QuestionWord { get; set; } // вопрос
        public string TextBoxText { get { return ""; } }

        private string rightAnswer;
        private void CheckAndWrite(string answerWord) {
            if (answerWord == rightAnswer) // проверка введённого слова
                answers[Counter - 1] = true;
            else answers[Counter - 1] = false;
            new FileWorker().WriteInFile(resultTestFilePath, QuestionWord, answerWord, answers[Counter - 1]); // запись результата в файл
            if (Counter < 15) {
                TestMethod();
            }
            else {
                Application.Current.MainWindow.DataContext = new TestResultView(); // показать результат
            }
        }

        /// <summary>
        /// Тестирование
        /// </summary>
        private void TestMethod() {
            if (testingWords != null) {
                string[] word = testingWords[Counter].Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (enLanguage) { // если английский язык
                    QuestionWord = word[0]; // слово на экране
                    rightAnswer = word[1];  // правильный ответ
                }
                else { // если русский язык
                    QuestionWord = word[1];
                    rightAnswer = word[0];
                }
                Counter++; // счётчик
            }
        }

        private void Load_Method() {
            new FileWorker().FileClear(resultTestFilePath);
            Counter = 0;
            testingWords = ReadWords();
            answers = new bool[15];
            TestMethod();
        }

        /// <summary>
        /// Считать все слова из файла
        /// </summary>
        /// <returns></returns>
        private string[] ReadWords() {
            string[] wordList = new FileWorker().ReadFile(wordFilePath);
            if (wordList != null) {
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
        private string[] FillTestArray(string[] arrayElements) {
            Random rnd = new Random();
            string[] array = new string[15];
            for (int i = 0; i < 15; i++) {
                int index = rnd.Next(0, arrayElements.Length);
                array[i] = arrayElements[index];
            }
            return array;
        }

        public void NextQuestion(string inputWord) {
            CheckAndWrite(inputWord);
        }

        public TestViewModel(bool language) {
            this.enLanguage = language;
            Load_Method();
        }
    }
}
