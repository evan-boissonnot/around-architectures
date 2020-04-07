using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Around.Architectures.Core.Businesses.TransactionScripts;
using Around.Architectures.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arround.Architectures.Web.UI.Controllers
{
    public class OrderController : Controller
    {
        [HttpPost]
        public IActionResult Create(Order order)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}