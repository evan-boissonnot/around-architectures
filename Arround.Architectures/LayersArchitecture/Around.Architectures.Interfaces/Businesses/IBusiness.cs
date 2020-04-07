using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Businesses
{
    public interface IBusiness<T> where T: IModel
    {
        IList<T> GetList(IFilter<T> filter);
    }
}
