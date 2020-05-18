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
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>(this IQueryable<T> source, Pagination pagination)
        {
            var count = source.Count();
            List<T> items = new List<T>();

            if (count > 0)
            {
                items = source.Skip((pagination.PageNumber - 1) * pagination.PageSize).Take(pagination.PageSize).ToList();
            }

            return new PagedList<T>(items, count, pagination.PageNumber, pagination.PageSize);
        }
        #endregion
    }
}
