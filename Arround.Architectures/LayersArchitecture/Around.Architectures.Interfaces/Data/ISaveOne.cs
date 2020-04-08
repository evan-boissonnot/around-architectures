using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data
{
    public interface ISaveOne<T> where T: IModel
    {
        void SaveOne(T item);
    }
}
