using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary slownik = new Dictionary();
            IDictionaryManager pomoc = new DictionaryManager();
            slownik.addWord(new Word("Hi","Cześć"));
            Console.WriteLine(pomoc.GetTranslationWordFromEng("Hi",slownik.words));
            Console.ReadKey();
            slownik.deleteWord(slownik.words[0]);
            Console.ReadKey();

        }
    }
}
