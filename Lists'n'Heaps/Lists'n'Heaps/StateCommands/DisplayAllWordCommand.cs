using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class DisplayAllWordCommand: AbstractWordCommand
    {
        public DisplayAllWordCommand(States _state, DictionaryManager _dictionaryManager) : base(_state, _dictionaryManager)
        {
        }

        public override void Execute()
        {
            this.dictionaryManager.DisplayAll();
            Console.ReadKey();
        }
    }
}
