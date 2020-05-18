using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Around.Architectures.Core.Businesses.TransactionScripts;
using Around.Architectures.Core.Filters;
using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Models;
using Around.Architectures.Core.Web.Controllers;
using Around.Architectures.Core.Web.Presentation;
using Around.Architectures.Core.Web.ViewModels;
using Boissonnot.Framework.Core.Collections.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;

namespace Arround.Architectures.Web.UI.Controllers
{
    public class OrderController : BaseController<Order>
    {
        #region Fields
        private OrderPresentation _orderPresentation = null;
        #endregion

        public OrderController(OrderPresentation orderPresentation)
        {
            this._orderPresentation = orderPresentation;
        }

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
            // https://www.strathweb.com/2018/01/easy-way-to-create-a-c-lambda-expression-from-a-string-with-roslyn/
            var viewModel = this._orderPresentation.GetList(new OrderListFilter(0), new Pagination(), new SortItem<Order>());

            return View(viewModel);
        }
    }
}