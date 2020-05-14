using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Interfaces.Data.Filters
{
    /// <summary>
    /// Uses it to create pagination and define the sort order
    /// </summary>
    public interface IResultFilter
    {
        /// <summary>
        /// Size of page : nb elements in each page
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// Current index of the page
        /// </summary>
        int PageIndex { get; set; }
    }
}
