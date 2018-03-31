using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    public class DictionaryManager: IDictionaryManager
    {
        public string GetPlWord(Word _word) => _word.pl;
        public string GetEngWord(Word _word) => _word.eng;

        public string GetTranslationWordFromEng(string _eng, List<Word> _dictionary)
        {
            //Size of letters has no matter 
            _eng = _eng.ToLower();
            //Search List of Words, and find the one that meets the translate condition
            string _pl =_dictionary.Where(i => i.eng == _eng).FirstOrDefault().pl;
            return _pl;
        }

        public string GetTranslationWordFromPl(string _pl, List<Word> _dictionary)
        {
            //The same as upper function
            _pl = _pl.ToLower();
            string _eng = _dictionary.Where(i => i.pl == _pl).FirstOrDefault().pl;
            return _eng;
        }

    }
}
