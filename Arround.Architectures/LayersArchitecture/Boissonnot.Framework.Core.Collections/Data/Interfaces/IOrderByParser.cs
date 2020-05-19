using System.Collections.Generic;

namespace Boissonnot.Framework.Core.Collections.Data.Interfaces
{
    public interface IOrderByParser
    {
        IEnumerable<OrderByInfo> Parse(string content);
    }
}