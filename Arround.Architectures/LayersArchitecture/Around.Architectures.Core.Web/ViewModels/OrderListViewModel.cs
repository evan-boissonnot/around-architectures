using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Web.ViewModels
{
    public class OrderListViewModel : IListViewModel<List<Order>, Order>
    {
        public IList<Order> Items { get; set; }
    }
}
