using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    class Dictionary
    {
        public List<Word> dictionary { get; set; }
        
        public Dictionary()
        {
            dictionary = new List<Word>();
        }

        void addWord(Word _word)
        {
            this.dictionary.Add(_word);
        }

    }
}
