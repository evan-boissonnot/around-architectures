using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Businesses
{
    public interface IOrderBusiness
    {
        IList<Order> GetList(IFilter<Order> filter);
    }
}
