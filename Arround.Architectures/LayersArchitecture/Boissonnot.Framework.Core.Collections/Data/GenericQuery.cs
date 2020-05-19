using Boissonnot.Framework.Core.Collections.Data;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Collections
{
    public class GenericQuery<T> where T: class
    {
        #region Fields
        private IFilter<T> _filters;
        private Pagination _pagination;
        private SortItem<T> _sortItem;
        private string _sortQuery;
        #endregion

        #region Constructors
        public GenericQuery(IFilter<T> filters, Pagination pagination, SortItem<T> sortItem, string orderQuery)
        {
            this.Filters = filters;
            this.Pagination = pagination;
            this.SortItem = sortItem;
            this.SortQuery = orderQuery;
        }

        public GenericQuery(IFilter<T> filters, Pagination pagination, SortItem<T> sortItem) : this(filters, pagination, sortItem, null)
        {
        }

        public GenericQuery(IFilter<T> filters, Pagination pagination, string orderQuery) : this(filters, pagination, null, orderQuery)
        {
        }
        #endregion

        #region Properties
        public IFilter<T> Filters { get => this._filters; private set => this._filters = value; }
        public Pagination Pagination { get => this._pagination; private set => this._pagination = value; }
        public SortItem<T> SortItem { get => this._sortItem; private set => this._sortItem = value; }
        public string SortQuery { get => this._sortQuery; private set => this._sortQuery = value; }
        #endregion
    }
}
