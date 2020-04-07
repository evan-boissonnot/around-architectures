using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Examples.Core.PatternCommand
{
    public class Invoker : IExecute
    {
        private Command _command;

        public void Execute()
        {
            this._command.Execute();
        }

        public Command Command { get => this._command; set => this._command = value; }
    }
}
