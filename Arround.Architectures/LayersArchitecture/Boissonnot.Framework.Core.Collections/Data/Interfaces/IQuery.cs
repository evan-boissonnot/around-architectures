using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data.Interfaces
{
    public interface IQuery<TEntity> where TEntity : class
    {
        Expression<Func<TEntity, bool>> Query();
    }
}
