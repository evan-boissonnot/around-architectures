using Around.Architectures.Core.Interfaces.Data.Businesses;
using Around.Architectures.Core.Interfaces.Models;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Boissonnot.Framework.Core.Collections;
using Boissonnot.Framework.Core.Collections.Data;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using Boissonnot.Framework.Core.Collections.Interfaces;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Around.Architectures.Core.Web.ViewModels;
using Around.Architectures.Core.Interfaces.UI.Presentations;

namespace Around.Architectures.Core.Web.Presentation
{
    public abstract class BasePresentation<T> : IPresentation<T>
                    where T: class, IModel
    {
        #region Fields
        private IBusinessOf<T> _business = null;
        #endregion

        #region Constructors
        public BasePresentation(IBusinessOf<T> business)
        {
            this._business = business;
        }
        #endregion

        #region Public methods
        public IListViewModel<T> GetList(IFilter<T> filters, Pagination pagination, SortItem<T> sortItem)
        {
            IGenericQuery<T> genericQuery = new GenericQuery<T>(filters, sortItem);

            return this.GetList(genericQuery, pagination);
        }

        public IListViewModel<T> GetList(IFilter<T> filters, Pagination pagination, string orderQuery)
        {
            IGenericQuery<T> genericQuery = new GenericQuery<T>(filters, orderQuery);

            return this.GetList(genericQuery, pagination);
        }
        #endregion

        #region Internal methods
        public IListViewModel<T> GetList(IGenericQuery<T> genericQuery, Pagination pagination)
        {
            var list = this._business.GetList(genericQuery);

            var pageList = list.ToPagedList(pagination);

            return new ListViewModel<T>(pageList.ToList());
        }
        #endregion
    }
}
