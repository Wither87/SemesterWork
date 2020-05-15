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
using Семестровка.Views;

namespace Семестровка.Views
{
    /// <summary>
    /// Логика взаимодействия для AddWordView.xaml
    /// </summary>
    public partial class AddWordView : UserControl
    {
        bool enWordInput = false, rusWordInput = false;
        readonly string directoryPath = @"..\..\..\Files";
        readonly string filePath = @"..\..\..\Files\Слова.txt";

        public AddWordView()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            WriteWordsInFile();
        }

        bool CheckInputWord(TextBox text) {
            if (text.Text == "")
                return false;
            else
                return true;
        }

        void WriteWordsInFile() {
            enWordInput = CheckInputWord(enTB);
            rusWordInput = CheckInputWord(rusTB);
            if(enWordInput && rusWordInput) {
                using (StreamWriter sw = new StreamWriter(filePath, true)) {
                    string str = $"{enTB.Text}:{rusTB.Text};";
                    sw.WriteLine(str);
                }
                enTB.Text = "";
                rusTB.Text = "";
            }
            else {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
