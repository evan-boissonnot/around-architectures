using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data.Businesses
{
    public interface IBusinessOf<T> : IGetListWithFilter<T>, ISaveOne<T> 
                                      where T: class, IModel
                    
    {
    }
}
