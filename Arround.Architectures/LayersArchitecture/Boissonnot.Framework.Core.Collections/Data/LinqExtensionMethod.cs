using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Extends linq with custom methods
    /// </summary>
    public static class LinqExtensionMethod
    {
        #region Public methods
        /// <summary>
        /// Custom order by with string rules (like Name Desc)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="sortQuery">String rules (like Name Desc)</param>
        /// <returns></returns>
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> items, string sortQuery)
        {
            IOrderByParser parser = new OrderByParser();
            OrderByBuilder<T> builder = new Data.OrderByBuilder<T>(items);

            return builder.Build(parser.Parse(sortQuery));
        }
        #endregion
    }
}
