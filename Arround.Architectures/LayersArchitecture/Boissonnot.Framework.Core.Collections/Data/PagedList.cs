using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Collection with pagination
    /// </summary>
    public class PagedList<T> : List<T>
    {
        #region Constructors
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            this.TotalCount = count;
            this.PageSize = pageSize;
            this.CurrentPage = pageNumber;
            this.TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Current index of page
        /// </summary>
        public int CurrentPage { get; private set; }

        /// <summary>
        /// Total of the pages
        /// </summary>
        public int TotalPages { get; private set; }

        /// <summary>
        /// Size of each page
        /// </summary>
        public int PageSize { get; private set; }

        /// <summary>
        /// Total of elements
        /// </summary>
        public int TotalCount { get; private set; }

        /// <summary>
        /// Could you go to previous page ?
        /// </summary>
        public bool HasPrevious => CurrentPage > 1;

        /// <summary>
        /// Could go to next page ?
        /// </summary>
        public bool HasNext => CurrentPage < TotalPages;
        #endregion
    }
}
