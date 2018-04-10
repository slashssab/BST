using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class TranslateAng2PlCommand : AbstractWordCommand
    {
        public TranslateAng2PlCommand(States _state, DictionaryManager _dictionaryManager) : base(_state, _dictionaryManager)
        {
        }

        public override void Execute()
        {
            string wordToTranslateA2P = Console.ReadLine();
            Console.WriteLine(this.dictionaryManager.GetTranslationWordFromEng(wordToTranslateA2P));
            Console.ReadKey();
        }
    }
}
