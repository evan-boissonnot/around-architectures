using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Allows you to sort all collections you want
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericSorter<T>
    {
        #region Fields
        private Expression<Func<T, object>>[] _orderBys;
        #endregion

        #region Constructors
        public GenericSorter(IQueryable<T> source)
        {
            this.Source = source;
        }

        public GenericSorter(IQueryable<T> source, params Expression<Func<T, object>>[] orderBys)
        {
            this.Source = source;
            this._orderBys = orderBys;
        }
        #endregion

        #region Public methods
        public IQueryable<T> Sort()
        {
            IQueryable<T> source = this.Source;

            if (this._orderBys != null)
            {
                IOrderedQueryable<T> query = null;

                foreach (var sort in this._orderBys)
                {
                    if (!this.IsAlreadyOrder)
                    {
                        query = this.Source.OrderBy(sort);
                    }
                    else
                    {
                        query = query.ThenBy(sort);
                    }
                }
                source = query;
            }

            return source;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Source of elements
        /// </summary>
        public IQueryable<T> Source { get; private set; }

        /// <summary>
        /// Alows you to know if the query is already ordered
        /// </summary>
        public bool IsAlreadyOrder => this.Source.Expression.Type == typeof(IOrderedQueryable<T>);
        #endregion
    }
}
