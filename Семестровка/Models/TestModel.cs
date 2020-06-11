using System;
using System.Collections.Generic;
using System.Text;

namespace Семестровка.Models {
    class TestModel {
        public int Counter { get; set; } // сщётчик
        public string QuestionWord { get; set; } // вопрос
        public string TextBoxText { get { return ""; } }
    }
}
