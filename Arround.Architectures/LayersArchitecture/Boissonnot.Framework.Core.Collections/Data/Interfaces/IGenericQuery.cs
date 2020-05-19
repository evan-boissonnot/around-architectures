using Boissonnot.Framework.Core.Collections.Data;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;

namespace Boissonnot.Framework.Core.Collections.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericQuery<T> where T : class
    {
        /// <summary>
        /// Filters to apply to the query
        /// </summary>
        IFilter<T> Filters { get; }

        /// <summary>
        /// Generic sort item (containing sort lambda expressions)
        /// </summary>
        SortItem<T> SortItem { get; }

        /// <summary>
        /// Query as string 
        /// </summary>
        string SortQuery { get; }
    }
}