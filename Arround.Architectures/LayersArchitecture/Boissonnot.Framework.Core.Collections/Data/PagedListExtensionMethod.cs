using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    public static class PagedListExtensionMethod
    {
        #region Public methods
        /// <summary>
        /// Converts a list to paged list
        /// </summary>
        /// <typeparam name="T">Item in the list</typeparam>
        /// <param name="source">Enumerable of T elements</param>
        /// <param name="pageNumber">Number of the current page</param>
        /// <param name="pageSize">Number of element in each page</param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
        #endregion
    }
}
