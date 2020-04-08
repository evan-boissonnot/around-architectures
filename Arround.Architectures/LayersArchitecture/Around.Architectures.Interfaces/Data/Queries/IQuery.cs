using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data.Queries
{
    public interface IQuery<TEntity> where TEntity : class
    {
        Expression<Func<TEntity, bool>> Query();
    }
}
