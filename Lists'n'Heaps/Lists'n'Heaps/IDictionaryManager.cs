using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    public interface IDictionaryManager
    {
        string GetPlWord(Word _word);
        string GetEngWord(Word _word);
        string GetTranslationWordFromEng(string _eng);
        string GetTranslationWordFromPl(string _eng);
        void addWord(string _eng, string _pl);
        void deleteWord(Word _word);
    }
}
