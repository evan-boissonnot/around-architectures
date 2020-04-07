using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Businesses.DomainModels
{
    public interface ISupportsValidation
    {
        bool IsValid { get; }
        IList<ValidationError> Validate();
    }
}
