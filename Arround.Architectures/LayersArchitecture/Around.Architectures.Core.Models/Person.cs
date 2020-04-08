using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Models
{
    public abstract class Person : IModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
