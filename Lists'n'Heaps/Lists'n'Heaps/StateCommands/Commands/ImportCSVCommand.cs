using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class ImportCSVCommand : AbstractWordCommand
    {
        public ImportCSVCommand(States _state, DictionaryManager _dictionaryManager) : base(_state, _dictionaryManager)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Podaj ściekę");
            string filepath = Console.ReadLine();
            this.dictionaryManager.ImportCSV(filepath);
        }
    }
}
