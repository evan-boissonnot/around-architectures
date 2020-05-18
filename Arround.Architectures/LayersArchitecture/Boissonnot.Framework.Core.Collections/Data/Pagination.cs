using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Uses it to define the page number and page size
    /// </summary>
    public class Pagination
    {
        #region Properties
        public int PageSize { get; set; }

        public int PageNumber { get; set; }
        #endregion
    }
}
