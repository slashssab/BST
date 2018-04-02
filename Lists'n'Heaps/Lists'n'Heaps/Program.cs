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
            States states = new States();
            MenuOrganizer menu = new MenuOrganizer();
            Dictionary slownik = new Dictionary();
            DictionaryManager pomoc = new DictionaryManager(slownik.words);
            pomoc.addWord("Hi","Cześć");
            pomoc.addWord("Loop", "Pętla");
            pomoc.addWord("Run", "Biegać");
            pomoc.addWord("Retarded", "Niedorozwinięty");

            menu.MenuLoop(states, pomoc);


        }
    }
}
