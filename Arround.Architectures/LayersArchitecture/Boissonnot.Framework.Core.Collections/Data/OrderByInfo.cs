using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Information of one criteria of order by
    /// </summary>
    public class OrderByInfo
    {
        #region Properties
        /// <summary>
        /// Name of the property
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Direction of the sort item
        /// </summary>
        public SortType Direction { get; set; }

        public bool First { get; set; } = true;
        #endregion
    }
}
