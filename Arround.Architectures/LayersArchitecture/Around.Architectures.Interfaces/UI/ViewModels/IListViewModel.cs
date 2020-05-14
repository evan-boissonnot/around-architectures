using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.UI.ViewModels
{
    public interface IListViewModel<U> where U: IModel
    {
        IList<U> Items { get; set; }
    }
}
