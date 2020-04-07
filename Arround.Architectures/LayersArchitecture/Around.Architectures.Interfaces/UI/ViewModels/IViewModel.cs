using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.UI.ViewModels
{
    public interface IViewModel<T> where T : IModel
    {
        T Item { get; set; }
    }
}
