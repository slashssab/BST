using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public abstract class AbstaractWordCommandFactory : IStateCommandFactory
    {
        protected States state { get; set; }
        protected DictionaryManager dictionaryManager{get; set;}
        public abstract IStateCommand GetCommand(States _state);
        public AbstaractWordCommandFactory(DictionaryManager _dictionaryManager)
        {
            dictionaryManager = _dictionaryManager;
        }

        public bool ShouldHandle(States _state)
        {
            return state == _state;
        }
    }

    public class AddWordCommandfactory : AbstaractWordCommandFactory
    {
        public AddWordCommandfactory(DictionaryManager _dictionaryManager) : base(_dictionaryManager)
        {
            state = States.addWord;
        }

        public override IStateCommand GetCommand(States _state)
        {
            return new AddWordCommand(_state, this.dictionaryManager);
        }
    }
    public class DeleteWordCommandfactory : AbstaractWordCommandFactory
    {
        public DeleteWordCommandfactory(DictionaryManager _dictionaryManager) : base(_dictionaryManager)
        {
            state = States.deleteWord;
        }

        public override IStateCommand GetCommand(States _state)
        {
            return new DeleteWordCommand(_state, this.dictionaryManager);
        }
    }
    public class TranslateAng2PlCommandFactory : AbstaractWordCommandFactory
    {
        public TranslateAng2PlCommandFactory(DictionaryManager _dictionaryManager) : base(_dictionaryManager)
        {
            state = States.translateAng2Pol;
        }

        public override IStateCommand GetCommand(States _state)
        {
            return new TranslateAng2PlCommand(_state, this.dictionaryManager);
        }
    }
    public class TranslatePol2angCommandFactory : AbstaractWordCommandFactory
    {
        public TranslatePol2angCommandFactory(DictionaryManager _dictionaryManager) : base(_dictionaryManager)
        {
            state = States.translatePol2ang;
        }

        public override IStateCommand GetCommand(States _state)
        {
            return new TranslatePol2angCommand(_state, this.dictionaryManager);
        }
    }
    public class DisplayAllWordCommandFactory : AbstaractWordCommandFactory
    {
        public DisplayAllWordCommandFactory(DictionaryManager _dictionaryManager) : base(_dictionaryManager)
        {
            state = States.DisplayAll;
        }

        public override IStateCommand GetCommand(States _state)
        {
            return new DisplayAllWordCommand(_state, this.dictionaryManager);
        }
    }
    public class SortDictionaryCommandFactory : AbstaractWordCommandFactory
    {
        public SortDictionaryCommandFactory(DictionaryManager _dictionaryManager) : base(_dictionaryManager)
        {
            state = States.Sort;
        }

        public override IStateCommand GetCommand(States _state)
        {
            return new SortDictionaryCommand(_state, this.dictionaryManager);
        }
    }
}
