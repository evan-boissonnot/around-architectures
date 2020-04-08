using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Around.Architectures.Core.Businesses.TransactionScripts;
using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Models;
using Around.Architectures.Core.Web.Controllers;
using Around.Architectures.Core.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Arround.Architectures.Web.UI.Controllers
{
    public class OrderController : BaseController<Order>
    {
        private IOrderBusiness _orderBusiness;

        public OrderController(IOrderBusiness orderBusiness)
        {
            this._orderBusiness = orderBusiness;
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            this._orderBusiness.SaveOne(order);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {
            OrderListViewModel viewModel = new OrderListViewModel();

            viewModel.Items = this._orderBusiness.GetList(null);

            return View(viewModel);
        }
    }
}