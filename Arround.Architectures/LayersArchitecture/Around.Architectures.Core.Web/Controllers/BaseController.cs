using Around.Architectures.Core.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Web.Controllers
{
    public class BaseController<T>: Controller where T: IModel
    {
        
    }
}
