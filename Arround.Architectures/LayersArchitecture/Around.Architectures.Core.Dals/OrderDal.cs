using Around.Architectures.Core.Data;
using Around.Architectures.Core.Interfaces.Data.Dals;
using Around.Architectures.Core.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using Boissonnot.Framework.Core.Collections.Interfaces;
using Boissonnot.Framework.Core.Collections.Data;

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

        public IQueryable<Order> GetList(IGenericQuery<Order> queryParam)
        {
            IQueryable<Order> query = this._context.Orders.Where(queryParam.Filters.Query());

            IGenericSorter<Order> sort = null;

            // TODO: create a fabric
            if (queryParam.SortItem != null)
            {
                sort = new GenericSorter<Order>(query, queryParam.SortItem.OrderBys);
            }
            else
            {
                sort = new StringGenericSorter<Order>(query, queryParam.SortQuery);
            }

            query = sort.Sort();

            return query;
        }
    }
}
