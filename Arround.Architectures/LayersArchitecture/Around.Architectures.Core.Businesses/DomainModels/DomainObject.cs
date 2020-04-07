using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Businesses.DomainModels
{
    public class DomainObject : ISupportsValidation
    {
        private IConstraintValidator _validator = null;

        public DomainObject(IConstraintValidator validator) => this._validator = validator;

        public bool IsValid { get => this._validator.IsValid(this); }

        public IList<ValidationError> Validate()
        {
            IList<ValidationError> errors;

            errors = this._validator.Validate(this);

            return errors;
        }
    }
}
