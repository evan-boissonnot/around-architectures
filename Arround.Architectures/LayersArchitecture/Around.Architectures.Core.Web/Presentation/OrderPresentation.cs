using Around.Architectures.Core.Filters;
using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Interfaces.UI.Presentations;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Around.Architectures.Core.Models;
using Around.Architectures.Core.Web.ViewModels;
using Boissonnot.Framework.Core.Collections;
using Boissonnot.Framework.Core.Collections.Data;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using Boissonnot.Framework.Core.Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Around.Architectures.Core.Web.Presentation
{
    public class OrderPresentation : IPresentation<Order>
    {
        #region Fields
        private IOrderBusiness _business = null;
        #endregion

        #region Constructors
        public OrderPresentation(IOrderBusiness business)
        {
            this._business = business;
        }
        #endregion

        #region Public methods
        public IListViewModel<Order> GetList(IFilter<Order> filters, Pagination pagination, SortItem<Order> sortItem)
        {
            IGenericQuery<Order> genericQuery = new GenericQuery<Order>(filters, sortItem);

            return this.GetList(genericQuery, pagination);
        }

        public IListViewModel<Order> GetList(IFilter<Order> filters, Pagination pagination, string orderQuery)
        {
            IGenericQuery<Order> genericQuery = new GenericQuery<Order>(filters, orderQuery);

            return this.GetList(genericQuery, pagination);
        }
        #endregion

        #region Internal methods
        public IListViewModel<Order> GetList(IGenericQuery<Order> genericQuery, Pagination pagination)
        {
            var list = this._business.GetList(genericQuery);

            var pageList = list.ToPagedList(pagination);

            return new OrderListViewModel(pageList.ToList());
        }
        #endregion
    }
}
