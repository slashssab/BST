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
        //Displays the menu commands
        private void DisplayMenu()
        {
            Console.WriteLine("0. Import słownika\n1. Słownik Polsko-Angielski\n2. Słownik Angielsko-Polski\n3. Dodaj słowo\n4. Usuń słowo\n5. Wyświetl\n6. Sort\n7. BST\n8. Wyjście");
        }

        //execute command in response of the input state
        private void ExecuteTask
            (
            States _state,
            IStateCommand _command,
            WordCommandFactory _factory,
            Invoker _invoker
            )
        {
            if(_state != States.Exit)
            {
                _command = _factory.GetCommand(_state);
                _invoker.SetCommand(_command);
                _invoker.ExecuteCommand();
            }
        }

        //Manages the menu as a state maschine
        public void MenuLoop
            (
            States _state, 
            DictionaryManager _dictionaryManager
            )
        {
            Invoker invoker = new Invoker();
            WordCommandFactory factory = new WordCommandFactory(_dictionaryManager);
            IStateCommand command = factory.GetCommand(_state);
            ConsoleKeyInfo keyinfo = Console.ReadKey();

            while (_state != States.Exit)
            {
                this.DisplayMenu();
                _state = States.idle;
                keyinfo = Console.ReadKey();
                if (keyinfo.KeyChar == '0') _state = States.import;
                if (keyinfo.KeyChar == '1') _state = States.translatePol2ang;
                if (keyinfo.KeyChar == '2') _state = States.translateAng2Pol;
                if (keyinfo.KeyChar == '3') _state = States.addWord;
                if (keyinfo.KeyChar == '4') _state = States.deleteWord;
                if (keyinfo.KeyChar == '5') _state = States.DisplayAll;
                if (keyinfo.KeyChar == '6') _state = States.Sort;
                if (keyinfo.KeyChar == '7') _state = States.BST;
                if (keyinfo.KeyChar == '8') _state = States.Exit;
                Console.ReadKey();
                this.ExecuteTask
                    (
                    _state,
                    command,
                    factory,
                    invoker                                   
                    );


                Console.Clear();
            }
        }
        
    }
}
