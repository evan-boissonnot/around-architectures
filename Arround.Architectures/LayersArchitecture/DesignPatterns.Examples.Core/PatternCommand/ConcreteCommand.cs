using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Examples.Core.PatternCommand
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            this._receiver.Action();
        }
    }
}
