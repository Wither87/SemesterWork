using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Семестровка
{
    public class FileWorker
    {
        public string[] SplitFile(string filePath) {
            string text = File.ReadAllText(filePath);
            if (text.Length != 0)
                return text.Split(":", StringSplitOptions.RemoveEmptyEntries);
            else return null;
        }

        public void WriteInFile(string path, string enWord, string ruWord) {
            using (StreamWriter sw = new StreamWriter(path, true)) {
                string str = $"{enWord}:{ruWord};";
                sw.WriteLine(str);
                sw.Close();
            }
        }
        public void WriteInFile(string path, string enWord, string ruWord, bool result) {
            using (StreamWriter sw = new StreamWriter(path, true)) {
                string str = $"{enWord}:{ruWord}:{result.ToString()};";
                sw.WriteLine(str);
                sw.Close();
            }
        }

        public void FileClear(string path) {
            File.Delete(path);
            File.Create(path);
        }

        public string[] ReadFile(string path) {
            string text = File.ReadAllText(path);
            string[] splitText = text.Split(";\r\n", StringSplitOptions.RemoveEmptyEntries);
            return splitText;
        }
    }
}
