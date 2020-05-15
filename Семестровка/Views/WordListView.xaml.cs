using System;
using System.Collections.Generic;
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
using System.IO;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для WordListView.xaml
    /// </summary>
    public partial class WordListView : UserControl
    {
        readonly string directoryPath = @"..\..\..\Files";
        readonly string filePath = @"..\..\..\Files\Слова.txt";

        public WordListView() {
            InitializeComponent();
            AddWordsInListBox();
        }

        void AddWordsInListBox()  {
            string[] splitFile = null;
            using(StreamReader sr = new StreamReader(filePath)) {
                string readedFile = sr.ReadToEnd();
                splitFile = readedFile.Split(";\r\n", StringSplitOptions.RemoveEmptyEntries);
            }
            if (splitFile != null)
                foreach (var item in splitFile) {
                    var word = item.Split(":");
                    listView.Items.Add(word);
                }
        }
    }
}
