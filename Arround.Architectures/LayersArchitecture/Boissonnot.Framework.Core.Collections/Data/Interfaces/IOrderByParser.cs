using System.Collections.Generic;

namespace Boissonnot.Framework.Core.Collections.Data
{
    public interface IOrderByParser
    {
        IEnumerable<OrderByInfo> Parse(string content);
    }
}