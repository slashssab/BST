using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public abstract class AbstractWordCommand : IStateCommand
    {
        protected States state;
        protected DictionaryManager dictionaryManager;
        public AbstractWordCommand(States _state, DictionaryManager _dictionaryManager)
        {
            dictionaryManager = _dictionaryManager;
            state = _state;
        }
        public abstract void Execute();
    }
}
