using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class TranslatePol2angCommand : AbstractWordCommand
    {
        public TranslatePol2angCommand(States _state, DictionaryManager _dictionaryManager) : base(_state, _dictionaryManager)
        {
        }

        public override void Execute()
        {
            string wordToTranslateP2A = Console.ReadLine();
            Console.WriteLine(this.dictionaryManager.GetTranslationWordFromPl(wordToTranslateP2A));
            Console.ReadKey();
        }
    }
}
