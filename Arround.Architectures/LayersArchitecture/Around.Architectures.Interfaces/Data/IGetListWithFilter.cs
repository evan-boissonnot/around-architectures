using Around.Architectures.Core.Interfaces.Models;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data
{
    public interface IGetListWithFilter<T> where T: class, IModel
    {
        IQueryable<T> GetList(IFilter<T> filter);
    }
}
