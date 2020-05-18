using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Generic sort item with expression list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SortItem<T>
    {
        #region Properties
        /// <summary>
        /// Order by list expression lambdas
        /// </summary>
        public Expression<Func<T, object>>[] OrderBys { get; set; }
        #endregion
    }
}
