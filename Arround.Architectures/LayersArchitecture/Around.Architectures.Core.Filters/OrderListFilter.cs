using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Around.Architectures.Core.Filters
{
    public class OrderListFilter : IFilter<Order>
    {
        private decimal? _amount = 0;

        public OrderListFilter(decimal? amount)
        {
            this._amount = amount;

        }

        public int Id { get; set; }
        public Order ByItem { get; set; }

        public Expression<Func<Order, bool>> Query()
        {
            return (x => !this._amount.HasValue || x.Amount > this._amount);
        }
    }
}
