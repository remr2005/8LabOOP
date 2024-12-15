using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    public class CustomArray<T> : ICollection<T>
    {
        /// <summary>
        /// list
        /// </summary>
        private List<T> _items = new();
        /// <summary>
        /// Count of items
        /// </summary>
        public int Count => _items.Count;
        /// <summary>
        /// IsReadOnly
        /// </summary>
        public bool IsReadOnly => ((ICollection<T>)_items).IsReadOnly;
        /// <summary>
        /// Add item to array
        /// </summary>
        /// <param name="item">item</param>
        public void Add(T item) => _items.Add(item);
        /// <summary>
        /// Clear array
        /// </summary>
        public void Clear() => _items.Clear();
        /// <summary>
        /// Contains item in array
        /// </summary>
        /// <param name="item">Some item</param>
        public bool Contains(T item) => _items.Contains(item);
        /// <summary>
        /// CopyTo method
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        public void CopyTo(T[] array, int index) => _items.CopyTo(array, index);
        /// <summary>
        /// Get ennumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_items).GetEnumerator();
        /// <summary>
        /// Remove some item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item) => ((ICollection<T>)_items).Remove(item);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()=>((IEnumerable)_items).GetEnumerator();
        /// <summary>
        /// Insert item in arrray 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, T item) => _items.Insert(index, item);
        /// <summary>
        /// reverse array
        /// </summary>
        public void Reverse() => _items.Reverse();
        /// <summary>
        /// Sort array
        /// </summary>
        public void Sort() => _items.Sort((x, y) => CompareObjects(x, y));
        /// <summary>
        /// Compare two objects
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private int CompareObjects(T x, T y)
        {
            // Сравниваем объекты различных типов
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            // Сравнение типов
            Type typeX = x.GetType();
            Type typeY = y.GetType();

            if (typeX == typeY)
            {
                // Если типы одинаковые, пробуем сравнить значения
                if (x is IComparable comparableX && y is IComparable comparableY)
                {
                    return comparableX.CompareTo(comparableY);
                }
                else
                {
                    throw new ArgumentException("Элементы не могут быть сравнены.");
                }
            }

            // Если типы разные, применяем произвольную логику, например, сравниваем по строковому представлению
            return x.ToString().CompareTo(y.ToString());
        }
        /// <summary>
        /// IndexOFF
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOff(T item) => _items.IndexOf(item);
    }
}

