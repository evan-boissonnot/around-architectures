using Around.Architectures.Core.Interfaces.Models;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Web.ViewModels
{
    public class ListViewModel<T> : IListViewModel<T>
                where T: class, IModel
    {
        #region Constructors
        public ListViewModel(IList<T> items)
        {
            this.Items = items;
        }
        #endregion

        #region Properties
        public IList<T> Items { get; set; }
        #endregion
    }
}
