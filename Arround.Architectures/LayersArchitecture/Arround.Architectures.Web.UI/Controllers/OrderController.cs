using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        public IActionResult Index([FromQuery] string sort)
        {

            var viewModel = this._orderPresentation.GetList(new OrderListFilter(0),
                                                            new Pagination() { PageNumber = 1, PageSize = 2 },
                                                            sort);

            return this.View(null);
        }
    }
}