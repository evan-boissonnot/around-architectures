using Around.Architectures.Core.Data;
using Around.Architectures.Core.Interfaces.Data.Dals;
using Around.Architectures.Core.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;

namespace Around.Architectures.Core.Dals
{
    public class OrderDal : IOrderDataLayer
    {
        private DefaultContext _context = null;

        public OrderDal(DefaultContext context)
        {
            this._context = context;
        }

        public void AddOne(Order item)
        {
            this._context.Orders.Add(item);
            this._context.SaveChanges();
        }

        public IQueryable<Order> GetList(IFilter<Order> filter)
        {
            return this._context.Orders.Where(filter.Query());
        }
    }
}
