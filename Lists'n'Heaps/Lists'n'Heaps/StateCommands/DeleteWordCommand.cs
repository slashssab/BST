using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class DeleteWordCommand : AbstractWordCommand
    {
        public DeleteWordCommand(States _state, DictionaryManager _dictionaryManager) : base(_state, _dictionaryManager)
        {
        }

        public override void Execute()
        {
            string wordToDelete = Console.ReadLine();
            this.dictionaryManager.deleteWord(new Word(wordToDelete, wordToDelete));
        }
    }
}
