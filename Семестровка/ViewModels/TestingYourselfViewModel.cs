using System.IO;
using System.Windows.Controls;

namespace Семестровка.ViewModels
{
    class TestingYourselfViewModel {
        private readonly string wordFilePath = @"Files\Слова.txt";

        private void CheckFile(Grid grid) {
            if (File.ReadAllText(wordFilePath) == "")
                foreach (var item in grid.Children)
                    if (item is Button)
                    {
                        Button but = item as Button;
                        but.IsEnabled = false;
                    }
        }

        public TestingYourselfViewModel(Grid selectGrid) {
            CheckFile(selectGrid);
        }
    }
}
