using System.Windows;

namespace Семестровка.ViewModels
{
    class AddWordViewModel {
        private readonly string filePath = @"Files\Слова.txt";
        public string EnWord { get; set; }
        public string RuWord { get; set; }

        private bool CheckInputWord(string text) {
            if (text == "")
                return false;
            else
                return true;
        }

        private void WriteWordsInFile() {
            bool enWordInput = CheckInputWord(EnWord);
            bool rusWordInput = CheckInputWord(RuWord);
            if (enWordInput && rusWordInput) {
                string enWord = EnWord.ToLower();
                string ruWord = RuWord.ToLower();
                FileWorker fw = new FileWorker();
                fw.WriteInFile(filePath, enWord, ruWord);
                EnWord = "";
                RuWord = "";
            }
            else {
                MessageBox.Show("Ошибка");
                // потом надо исправить
            }
        }

        public void WriteInFile() {
            WriteWordsInFile();
        }
    }
}
