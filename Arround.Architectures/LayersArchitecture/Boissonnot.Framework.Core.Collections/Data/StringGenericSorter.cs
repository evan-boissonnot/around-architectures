using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    public class StringGenericSorter<T> : IGenericSorter<T>
    {
        #region Fields
        private string _query;
        #endregion

        #region Constructors
        public StringGenericSorter(IQueryable<T> source)
        {
            this.Source = source;
        }

        public StringGenericSorter(IQueryable<T> source, string query) : this(source)
        {
            this._query = query;
        }
        #endregion

        #region Public methods
        public IQueryable<T> Sort()
        {
            var queryResult = this.Source;

            if (!string.IsNullOrEmpty(this._query))
            {
                queryResult = this.Source.OrderBy(this._query);
            }

            return queryResult;
        }
        #endregion

        #region Properties

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
