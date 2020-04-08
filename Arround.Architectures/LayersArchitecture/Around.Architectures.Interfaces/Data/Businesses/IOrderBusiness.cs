using Around.Architectures.Core.Interfaces.Data;
using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Businesses
{
    public interface IOrderBusiness : IGetListWithFilter<Order>, ISaveOne<Order>
    {
    }
}
