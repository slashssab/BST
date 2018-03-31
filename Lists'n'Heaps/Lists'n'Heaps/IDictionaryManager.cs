﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    interface IDictionaryManager
    {
        string GetPlWord(Word _word);
        string GetEngWord(Word _word);
        string GetTranslationWordFromEng(string _eng, List<Word> _dictionary);
        string GetTranslationWordFromPl(string _eng, List<Word> _dictionary);
    }
}