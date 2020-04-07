using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Web.ViewModels
{
    public class OrderViewModel : IViewModel<Order>
    {
        public OrderViewModel(Order item)
        {
            this.Item = item;
        }

        public Order Item { get; set; }
    }
}
