using Around.Architectures.Core.Interfaces.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Around.Architectures.Core.Models
{
    public class Order : IList<Row>, IModel
    {
        #region Fields
        private List<Row> _rows = new List<Row>();
        #endregion

        #region Properties
        public int Id { get; set; }

        public Row this[int index] { get => this._rows[index]; set => this._rows[index] = value; }

        public IList<Row> Items { get; set; }

        public decimal Amount { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public int Count => this._rows.Count;

        public bool IsReadOnly => false;
        #endregion

        public void Add(Row item)
        {
            this._rows.Add(item);
        }

        public void Clear()
        {
            this._rows.Clear();
        }

        public bool Contains(Row item)
        {
            return this._rows.Contains(item);
        }

        public void CopyTo(Row[] array, int arrayIndex)
        {
            this._rows.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Row> GetEnumerator()
        {
            return this._rows.GetEnumerator();
        }

        public int IndexOf(Row item)
        {
            return this._rows.IndexOf(item);
        }

        public void Insert(int index, Row item)
        {
            this._rows.Insert(index, item);
        }

        public bool Remove(Row item)
        {
            return this._rows.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this._rows.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._rows.GetEnumerator();
        }
    }
}
