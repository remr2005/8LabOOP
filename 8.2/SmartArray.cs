using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    public class SmartArray : IList<int>
    {
        /// <summary>
        /// 
        /// </summary>
        private int[] _array;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lenght"></param>
        /// <exception cref="ArgumentException"></exception>
        public SmartArray(int lenght)
        {
            if (lenght <= 0) throw new ArgumentException("Размер массива должен быть больше нуля.");
            _array = new int[lenght];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= _array.Length) throw new IndexOutOfRangeException("Индекс находится за пределами массива.");
                return _array[index];
            }
            set
            {
                if (value < 0 || index < 0 || index >= _array.Length) throw new ArgumentException("Значение не может быть отрицательным.");
                _array[index] = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Count => _array.Length;
        /// <summary>
        /// 
        /// </summary>
        public bool IsReadOnly => false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="NotSupportedException"></exception>
        public void Add(int item)
        {
            throw new NotSupportedException("Невозможно добавить элементы в фиксированный массив.");
        }
        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            Array.Clear(_array, 0, _array.Length);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(int item)
        {
            return Array.Exists(_array, x => x == item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(int[] array, int arrayIndex)
        {
            _array.CopyTo(array, arrayIndex);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _array)
                yield return item;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(int item)
        {
            return Array.IndexOf(_array, item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        /// <exception cref="NotSupportedException"></exception>
        public void Insert(int index, int item)
        {
            throw new NotSupportedException("Невозможно вставить элементы в фиксированный массив.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public bool Remove(int item)
        {
            throw new NotSupportedException("Удаление элементов не поддерживается.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="NotSupportedException"></exception>
        public void RemoveAt(int index)
        {
            throw new NotSupportedException("Удаление элементов не поддерживается.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
