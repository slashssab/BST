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

    }
}
