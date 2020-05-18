using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    public enum SortType
    {
        Asc,
        Desc
    }

    public class SortItem<T>
    {
        public SortType SortType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Expression<Func<T, object>>[] OrderBys { get; set; }
    }
}
