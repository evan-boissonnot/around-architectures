using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Filters
{
    public interface IFilter<T>
    {
        int Id { get; set; }

        T ByItem { get; set; }
    }
}
