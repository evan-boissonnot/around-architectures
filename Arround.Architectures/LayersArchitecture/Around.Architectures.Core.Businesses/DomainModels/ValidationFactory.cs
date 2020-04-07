using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Businesses.DomainModels
{
    public class ValidationFactory
    {
        public static IConstraintValidator Create(Type type)
        {
            return new ConstraintValidator();
        }
    }
}
