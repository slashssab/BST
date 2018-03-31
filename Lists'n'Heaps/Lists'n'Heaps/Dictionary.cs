using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    class Dictionary
    {
        public List<Word> words { get; set; }
        
        public Dictionary()
        {
            words = new List<Word>();
        }

        public void addWord(Word _word)
        {
            _word.eng = _word.eng.ToLower();
            _word.pl = _word.pl.ToLower();
            this.words.Add(_word);
        }
        public void deleteWord(Word _word)
        {
            if (this.words.Where(i => i.eng == _word.eng) != null)
                this.words.Remove(this.words.Where(i => i.eng == _word.eng).FirstOrDefault());
        }

    }
}
