using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lists_n_Heaps
{
    class Program
    {
        static void Main(string[] args)
        {

            States states = new States();
            MenuOrganizer menu = new MenuOrganizer();
            Dictionary slownik = new Dictionary();
            DictionaryManager manager = new DictionaryManager(slownik.words);
            //manager.addWord("Hi","Cześć");
            //manager.addWord("Loop", "Pętla");
            //manager.addWord("Run", "Biegać");
            //manager.addWord("Retarded", "Niedorozwinięty");
            //manager.addWord("Michael", "Michał" );
            //manager.addWord("Wing", "Skrzydło");


            
            menu.MenuLoop(states, manager);


        }
        
    }
}
