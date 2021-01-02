using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class Invoker
    {
        ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void Execute()
        {
            command.Execute();
        }
    }
}
