using Boissonnot.Framework.Core.Collections.Data;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using Boissonnot.Framework.Core.Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Collections
{
    public class GenericQuery<T> : IGenericQuery<T> where T : class
    {
        #region Fields
        private IFilter<T> _filters;
        private SortItem<T> _sortItem;
        private string _sortQuery;
        #endregion

        #region Constructors
        public GenericQuery(IFilter<T> filters, SortItem<T> sortItem, string orderQuery)
        {
            this.Filters = filters;
            this.SortItem = sortItem;
            this.SortQuery = orderQuery;
        }

        public GenericQuery(IFilter<T> filters, SortItem<T> sortItem) : this(filters, sortItem, null)
        {
        }

        public GenericQuery(IFilter<T> filters, string orderQuery) : this(filters, null, orderQuery)
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Filters to apply to the query
        /// </summary>
        public IFilter<T> Filters { get => this._filters; private set => this._filters = value; }

        /// <summary>
        /// Generic sort item (containing sort lambda expressions)
        /// </summary>
        public SortItem<T> SortItem { get => this._sortItem; private set => this._sortItem = value; }

        /// <summary>
        /// Query as string 
        /// </summary>
        public string SortQuery { get => this._sortQuery; private set => this._sortQuery = value; }
        #endregion
    }
}
