using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Web.ViewModels
{
    /// <summary>
    /// ViewModel from a list of order
    /// </summary>
    public class OrderListViewModel : IListViewModel<Order>
    {
        #region Constructors
        public OrderListViewModel(IList<Order> items)
        {
            this.Items = items;
        }
        #endregion

        #region Properties
        public IList<Order> Items { get; set; }
        #endregion
    }
}
