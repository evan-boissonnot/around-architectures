using System.Collections;
using System.Collections.Generic;

namespace Around.Architectures.Core.Businesses.DomainModels
{
    public class ConstraintValidator : IConstraintValidator
    {
        public bool IsValid(object item)
        {
            return true;
        }

        public IList<ValidationError> Validate(object item)
        {
            List<ValidationError> errors = new List<ValidationError>();

            return errors;
        }
    }
}