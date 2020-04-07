using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Examples.Core.PatternCommand
{
    public abstract class Command : IExecute
    {
        protected Receiver _receiver;

        public Command(Receiver receiver) => this._receiver = receiver;

        public abstract void Execute();
    }
}
