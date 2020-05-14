using Around.Architectures.Core.Interfaces.Filters;
using Around.Architectures.Core.Interfaces.Models;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Around.Architectures.Core.Interfaces.UI.Presentations
{
    public interface IPresentation<T> where T : class, IModel 
    {
        IListViewModel<T> GetList(IFilter<T> filters, params Expression<Func<T, object>>[] orderBys);
    }
}
