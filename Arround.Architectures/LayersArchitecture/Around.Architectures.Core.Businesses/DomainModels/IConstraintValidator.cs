using System.Collections.Generic;

namespace Around.Architectures.Core.Businesses.DomainModels
{
    public interface IConstraintValidator
    {
        bool IsValid(object item);
        IList<ValidationError> Validate(object item);
    }
}