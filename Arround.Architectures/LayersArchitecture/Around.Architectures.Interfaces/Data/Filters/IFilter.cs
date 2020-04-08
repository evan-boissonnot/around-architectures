using Around.Architectures.Core.Interfaces.Data.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Filters
{
    public interface IFilter<T> : IQuery<T> where T: class
    {
        int Id { get; set; }

        T ByItem { get; set; }
    }
}
