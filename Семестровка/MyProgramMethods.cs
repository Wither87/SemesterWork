using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Семестровка
{
    public class MyProgramMethods
    {
        public string[] SplitFile(string filePath) {
            string text = File.ReadAllText(filePath);
            if (text.Length != 0)
                return text.Split(":", StringSplitOptions.RemoveEmptyEntries);
            else return null;
        }
    }
}
