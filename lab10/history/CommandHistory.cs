using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.commands
{
    public class CommandHistory
    {
        private Stack<ICommand> history = new Stack<ICommand>();

        public void ProcessCommand(ICommand command)
        {
            history.Push(command);
            command.Do();
        }
    }
}
