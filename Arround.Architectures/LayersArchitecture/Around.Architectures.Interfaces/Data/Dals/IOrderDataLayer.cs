using Around.Architectures.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data.Dals
{
    public interface IOrderDataLayer : IGetListWithFilter<Order>, IAddItem<Order>
    {
    }
}
