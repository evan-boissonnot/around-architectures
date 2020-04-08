using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Interfaces.Data;
using Around.Architectures.Core.Interfaces.Data.Dals;
using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Businesses
{
    public class OrderBusiness : IOrderBusiness
    {
        private IOrderDataLayer _layer = null;

        public OrderBusiness(IOrderDataLayer layer)
        {
            this._layer = layer;
        }

        public IList<Order> GetList(IFilter<Order> filter)
        {
            return this._layer.GetList(filter);
        }

        public void SaveOne(Order item)
        {
            if (item.Id == 0)
            {
                this._layer.AddOne(item);
            }
        }
    }
}
