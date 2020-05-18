using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Interfaces.Models;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Boissonnot.Framework.Core.Collections.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Around.Architectures.Core.Interfaces.UI.Presentations
{
    public interface IPresentation<T> where T : class, IModel 
    {
        /// <summary>
        /// Gets list with lambda order queries
        /// </summary>
        /// <returns></returns>
        IListViewModel<T> GetList(IFilter<T> filters, Pagination pagination, SortItem<T> sortItem);

        /// <summary>
        /// Gets list with string order queries
        /// </summary>
        /// <param name="orderQuery">Query like Item ASC</param>
        /// <returns></returns>
        IListViewModel<T> GetList(IFilter<T> filters, Pagination pagination, string orderQuery);
    }
}
