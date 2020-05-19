using Around.Architectures.Core.Filters;
using Around.Architectures.Core.Interfaces.Businesses;
using Around.Architectures.Core.Interfaces.Data.Businesses;
using Around.Architectures.Core.Interfaces.UI.Presentations;
using Around.Architectures.Core.Interfaces.UI.ViewModels;
using Around.Architectures.Core.Models;
using Around.Architectures.Core.Web.ViewModels;
using Boissonnot.Framework.Core.Collections;
using Boissonnot.Framework.Core.Collections.Data;
using Boissonnot.Framework.Core.Collections.Data.Interfaces;
using Boissonnot.Framework.Core.Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Around.Architectures.Core.Web.Presentation
{
    public class OrderPresentation : BasePresentation<Order>
    {
        #region Fields
        private IOrderBusiness _business = null;
        #endregion

        #region Constructors
        public OrderPresentation(IBusinessOf<Order> business) : base(business)
        {
        }
        #endregion
    }
}
