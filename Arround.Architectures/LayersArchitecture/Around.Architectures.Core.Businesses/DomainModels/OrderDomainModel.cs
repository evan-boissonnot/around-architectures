using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Around.Architectures.Core.Businesses.DomainModels
{
    public class OrderDomainModel : DomainObject
    {
        public OrderDomainModel(IConstraintValidator validator) : base(validator)
        {
        }

        [Required]
        public decimal Amount { get; set; }
    }
}
