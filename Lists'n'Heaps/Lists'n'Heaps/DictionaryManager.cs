using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    public class DictionaryManager: IDictionaryManager
    {
        private List<Word> dictionary { get;  set; }
        public DictionaryManager(List<Word> _dictionary)
        {
            dictionary = _dictionary;
        }
        public string GetPlWord(Word _word) => _word.pl;
        public string GetEngWord(Word _word) => _word.eng;

        public string GetTranslationWordFromEng(string _eng)
        {
            //Size of letters has no matter 
            _eng = _eng.ToLower();
            //Search List of Words, and find the one that meets the translate condition
            if(dictionary.Contains(dictionary.Where(i => i.eng == _eng).FirstOrDefault()))
            return dictionary.Where(i => i.eng == _eng).FirstOrDefault().pl;
            else
                throw new Exception(String.Format("Słowo {0} nie jest w słowniku", _eng));
        }

        public string GetTranslationWordFromPl(string _pl)
        {
            //The same as upper function
            _pl = _pl.ToLower();
            if (dictionary.Contains(dictionary.Where(i => i.pl == _pl).FirstOrDefault()))
                return dictionary.Where(i => i.pl == _pl).FirstOrDefault().eng;
            else
                throw new Exception(String.Format("Słowo {0} nie jest w słowniku", _pl));
        }

        public void addWord(string _eng, string _pl)
        {
            _eng = _eng.ToLower();
            _pl = _pl.ToLower();
            dictionary.Add(new Word(_eng, _pl));
        }

        public void deleteWord(Word _word)
        {
            if (dictionary.Contains(_word)) dictionary.Remove(dictionary.Where(i => i.eng == _word.eng).FirstOrDefault());
            else throw new Exception(String.Format("Word {0} is not a known word", _word.pl));
        }

        public void DisplayAll()
        {
            foreach(Word word in dictionary)
            {
                Console.WriteLine("Pl: {0}, Ang: {1}", Encoding.ASCII.GetBytes(word.pl)[0], word.eng);
            }

        }

    }
}
