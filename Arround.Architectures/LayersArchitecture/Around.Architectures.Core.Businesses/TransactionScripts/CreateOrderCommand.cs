using Around.Architectures.Core.Models;
using DesignPatterns.Examples.Core.PatternCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Businesses.TransactionScripts
{
    public class CreateOrderCommand : ICommand
    {
        #region Fields
        private Order _order = null;
        #endregion

        #region Constructors
        public CreateOrderCommand(Order order) => this._order = order;
        #endregion

        #region Public methods
        public void Execute()
        {
            Console.WriteLine("Saving order {0}", this._order.Id);
        }
        #endregion
    }
}
