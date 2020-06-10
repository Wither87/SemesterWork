using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Семестровка.ViewModels
{
    class TestResultViewModel {
        private readonly string resultTestFilePath = @"Files\Результат теста.txt";
        private StackPanel first;
        private StackPanel second;

        private void GetResults() {
            string[] readResults = new FileWorker().ReadFile(resultTestFilePath);
            foreach (var item in readResults) {
                string[] wordResult = item.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string first = wordResult[0];
                string second = wordResult[1];
                if (wordResult[2] == "True") {
                    WriteInStackPanel(first, second, Brushes.Lime);
                }
                else if (wordResult[2] == "False") {
                    WriteInStackPanel(first, second, Brushes.Red);
                }
            }
        }

        private void WriteInStackPanel(string firstWord, string secondWord, SolidColorBrush color) {
            TextBlock firstTB = new TextBlock { Text = firstWord, Background = color };
            first.Children.Add(firstTB);
            TextBlock secndTB = new TextBlock { Text = secondWord, Background = color };
            second.Children.Add(secndTB);
        }

        public void ShowResulrs() {
            GetResults();
        }

        public TestResultViewModel(StackPanel first, StackPanel second) {
            this.first = first;
            this.second = second;
        }
    }
}
