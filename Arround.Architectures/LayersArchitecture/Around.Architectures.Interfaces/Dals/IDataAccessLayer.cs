using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Dals
{
    public interface IDataAccessLayer<T> where T: IModel
    {
        void Add(T item);

        IList<T> 
    }
}
