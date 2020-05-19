using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data.Interfaces
{
    public interface IFilter<T> : IQuery<T> where T: class
    {
        int Id { get; set; }

        T ByItem { get; set; }
    }
}
