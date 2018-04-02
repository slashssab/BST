using Lists_n_Heaps.StateCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps
{
    class MenuOrganizer
    {
        
        private void DisplayMenu()
        {
            Console.WriteLine("1. Słownik Polsko-Angielski\n2. Słownik Angielsko-Polski\n3. Dodaj słowo\n4. Usuń słowo\n5. Wyjście");
        }

        private void ExecuteTask
            (
            States _state,
            DictionaryManager _dictionaryManager
            )
        {
            
                
        }

        public void MenuLoop
            (
            States _state, 
            DictionaryManager _dictionaryManager
            )
        {
            Invoker invoker = new Invoker();

            ConsoleKeyInfo keyinfo = Console.ReadKey();
            while (_state != States.Exit)
            {
                this.DisplayMenu();
                _state = States.idle;
                keyinfo = Console.ReadKey();
                if (keyinfo.KeyChar == '1') _state = States.translatePol2ang;
                if (keyinfo.KeyChar == '2') _state = States.translateAng2Pol;
                if (keyinfo.KeyChar == '3') _state = States.addWord;
                if (keyinfo.KeyChar == '4') _state = States.deleteWord;
                if (keyinfo.KeyChar == '5') _state = States.Exit;
                //this.ExecuteTask
                //    (
                //    _state,  
                //    _dictionaryManager
                //    );

                WordCommandFactory factory = new WordCommandFactory(_dictionaryManager);
                IStateCommand command = factory.GetCommand(_state);
                invoker.SetCommand(command);
                invoker.ExecuteCommand();
                Console.Clear();
            }
        }
        
    }
}
