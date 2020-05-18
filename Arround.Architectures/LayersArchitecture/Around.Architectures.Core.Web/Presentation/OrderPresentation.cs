using Around.Architectures.Core.Filters;
using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Interfaces.UI.Presentations;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Around.Architectures.Core.Models;
using Around.Architectures.Core.Web.ViewModels;
using Boissonnot.Framework.Core.Collections.Data;
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
            var list = this._business.GetList(filters);
            var sort = new GenericSorter<Order>(list.AsQueryable(), sortItem.OrderBys);
            var query = sort.Sort();

            var pageList = query.ToPagedList(pagination);

            return new OrderListViewModel(pageList.ToList());
        }

        public IListViewModel<Order> GetList(IFilter<Order> filters, Pagination pagination, string orderQuery)
        {
            var list = this._business.GetList(filters);
            list = list.OrderBy(orderQuery);

            var pageList = list.ToPagedList(pagination);

            return new OrderListViewModel(pageList.ToList());
        }
        #endregion
    }
}
