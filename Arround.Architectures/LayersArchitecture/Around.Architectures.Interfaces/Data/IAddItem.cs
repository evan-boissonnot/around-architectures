using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data
{
    public interface IAddItem<T> where T: IModel
    {
        void AddOne(T item);
    }
}
