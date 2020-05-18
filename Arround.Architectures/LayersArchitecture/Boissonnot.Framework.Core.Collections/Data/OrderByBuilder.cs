using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    public class OrderByBuilder<T>
    {
        #region Fields
        private IQueryable<T> _collection;
        #endregion

        #region Constructors
        public OrderByBuilder(IQueryable<T> collection)
        {
            this._collection = collection;
        }
        #endregion

        #region Public methods
        public IQueryable<T> Build(IEnumerable<OrderByInfo> orderByInfos)
        {
            IQueryable<T> collection = this._collection;

            foreach (var orderItem in orderByInfos)
            {
                collection = this.Build(collection, orderItem);
            }

            return collection;
        }
        #endregion

        #region Inernal methods
        public IQueryable<T> Build(IQueryable<T> collection, OrderByInfo orderByInfo)
        {
            Type type = typeof(T);
            string[] props = orderByInfo.PropertyName.Split('.');
            ParameterExpression arg = Expression.Parameter(type, "x");
            Expression expr = arg;

            foreach (string prop in props)
            {
                PropertyInfo propertyInfo = type.GetProperties().First(item => item.Name.ToLower() == prop);
                expr = Expression.Property(expr, propertyInfo);
                type = propertyInfo.PropertyType;
            }
            Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
            LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

            string methodName = this.GetMethodName(orderByInfo, collection);
            return (IOrderedQueryable<T>)typeof(Queryable).GetMethods().Single(
                method => method.Name == methodName
                        && method.IsGenericMethodDefinition
                        && method.GetGenericArguments().Length == 2
                        && method.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(T), type)
                .Invoke(null, new object[] { collection, lambda });
        }

        private string GetMethodName(OrderByInfo orderByInfo, IQueryable<T> collection)
        {
            string methodName = "OrderBy";
            string suffix = string.Empty;

            if (!orderByInfo.First && collection is IOrderedQueryable<T>)
            {
                methodName = "ThenBy";
            }

            if (orderByInfo.Direction == SortType.Desc)
            {
                methodName += "Descending";
            }

            return methodName;
        }
        #endregion
    }
}
