using Around.Architectures.Core.Data;
using Around.Architectures.Core.Interfaces.Dals;
using Around.Architectures.Core.Models;
using System;

namespace Around.Architectures.Core.Dals
{
    public class OrderDal : IDataAccessLayer<Order>
    {
        private DefaultContext _context = null;

        public OrderDal(DefaultContext context)
        {
            this._context = context;
        }

        public void Add(Order order)
        {
            this._context.Orders.Add(order);
            this._context.SaveChanges();
        }
    }
}
