using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Collections.Data
{
    /// <summary>
    /// Parse a string and generate a list of <c>sort item</c>
    /// </summary>
    public class OrderByParser : IOrderByParser
    {
        #region Public methods
        public IEnumerable<OrderByInfo> Parse(string content)
        {
            string[] orderListValues = content.Split(',');
            bool isFirst = true;

            foreach (var orderString in orderListValues)
            {
                string[] orderByParts = orderString.Split(' ');

                object sortTypeTest = null;
                SortType sortType = SortType.Asc;
                if (Enum.TryParse(typeof(SortType), orderByParts[1], out sortTypeTest))
                {
                    sortType = (SortType)sortTypeTest;
                }

                yield return new OrderByInfo()
                {
                    PropertyName = orderByParts[0].Trim(),
                    Direction = sortType,
                    First = isFirst
                };

                isFirst = false;
            }
        }
        #endregion
    }
}
