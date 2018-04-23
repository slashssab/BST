using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class AddWordCommand : AbstractWordCommand
    {
        public AddWordCommand(States _state, DictionaryManager _dictionaryManager) : base(_state, _dictionaryManager)
        {
        }

        public override void Execute()
        {
            string eng = Console.ReadLine();
            string pl = Console.ReadLine();
            this.dictionaryManager.addWord(eng, pl);
        }
    }
}
