using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Businesses.TransactionScripts
{
    public interface ICommand
    {
        void Execute();
    }
}
