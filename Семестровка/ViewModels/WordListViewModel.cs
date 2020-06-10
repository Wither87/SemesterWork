using System.Windows.Controls;

namespace Семестровка.ViewModels
{
    class WordListViewModel {
        readonly string filePath = @"Files\Слова.txt";
        private ListView listView;
        private void AddWordsInListView() {
            FileWorker fw = new FileWorker();
            string[] wordsList = fw.ReadFile(filePath);
            if (wordsList != null)
                foreach (var item in wordsList) {
                    string[] word = item.Split(":");
                    listView.Items.Add(word);
                }
        }

        public WordListViewModel(ListView list) {
            this.listView = list;
            AddWordsInListView();
        }
    }
}
