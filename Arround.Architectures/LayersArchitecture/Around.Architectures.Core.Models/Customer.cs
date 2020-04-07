using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Models
{
    public class Customer : IModel
    {
        public int Id { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
