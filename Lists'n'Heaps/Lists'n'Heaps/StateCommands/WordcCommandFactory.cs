using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public class WordCommandFactory : IStateCommandFactory
    {
        List<AbstaractWordCommandFactory> Factories { get; set; }

        public WordCommandFactory(DictionaryManager _dictionaryManager)
        {
            Factories = new List<AbstaractWordCommandFactory>();
            Factories.Add(new AddWordCommandfactory(_dictionaryManager));
            Factories.Add(new DeleteWordCommandfactory(_dictionaryManager));
            Factories.Add(new TranslateAng2PlCommandFactory(_dictionaryManager));
            Factories.Add(new TranslatePol2angCommandFactory(_dictionaryManager));
            Factories.Add(new DisplayAllWordCommandFactory(_dictionaryManager));
            Factories.Add(new SortDictionaryCommandFactory(_dictionaryManager));
        }
        public IStateCommand GetCommand(States state)

        {
           foreach(AbstaractWordCommandFactory factory in Factories)
            {
                if (factory.ShouldHandle(state))
                    return factory.GetCommand(state);
            }
            return null;
        }
    }
}
