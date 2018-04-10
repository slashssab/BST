using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands
{
    public interface IStateCommandFactory
    {
        IStateCommand GetCommand(States state);
    }
}
