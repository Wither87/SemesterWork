using System.IO;

namespace Семестровка.ViewModels
{
    class MainWindowViewModel {
        private readonly string directoryPath = @"Files";
        private readonly string wordFilePath = @"Files\Слова.txt";
        private readonly string resultTestFilePath = @"Files\Результат теста.txt";

        public void CheckFileAndDirectory() {
            if (!Directory.Exists(directoryPath)) {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(wordFilePath)) {
                File.Create(wordFilePath);
            }
            if (!File.Exists(resultTestFilePath)) {
                File.Create(resultTestFilePath);
            }
        }
    }
}
