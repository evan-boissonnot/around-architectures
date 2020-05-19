using System.Linq;

namespace Boissonnot.Framework.Core.Collections.Data
{
    public interface IGenericSorter<T>
    {
        bool IsAlreadyOrder { get; }
        IQueryable<T> Source { get; }

        IQueryable<T> Sort();
    }
}