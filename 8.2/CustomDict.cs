using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    public class CustomDict<T, G> : IDictionary<T, G>
    {
        /// <summary>
        /// 
        /// </summary>
        private List<KeyValuePair<T, G>> _entries = new();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public G this[T key]
        {
            get
            {
                foreach (var pair in _entries)
                {
                    if (EqualityComparer<T>.Default.Equals(pair.Key, key))
                    {
                        return pair.Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                for (int i = 0; i < _entries.Count; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(_entries[i].Key, key))
                    {
                        _entries[i] = new KeyValuePair<T, G>(key, value);
                        return;
                    }
                }
                _entries.Add(new KeyValuePair<T, G>(key, value));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<T> Keys
        {
            get
            {
                List<T> keys = new();
                foreach (var pair in _entries)
                {
                    keys.Add(pair.Key);
                }
                return keys;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<G> Values
        {
            get
            {
                List<G> values = new();
                foreach (var pair in _entries)
                {
                    values.Add(pair.Value);
                }
                return values;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Count => _entries.Count;
        /// <summary>
        /// 
        /// </summary>
        public bool IsReadOnly => false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void Add(T key, G value)
        {
            if (ContainsKey(key))
            {
                throw new ArgumentException("An element with the same key already exists.");
            }
            _entries.Add(new KeyValuePair<T, G>(key, value));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(KeyValuePair<T, G> item)
        {
            Add(item.Key, item.Value);
        }
        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            _entries.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(KeyValuePair<T, G> item)
        {
            foreach (var pair in _entries)
            {
                if (EqualityComparer<T>.Default.Equals(pair.Key, item.Key) && EqualityComparer<G>.Default.Equals(pair.Value, item.Value))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(T key)
        {
            foreach (var pair in _entries)
            {
                if (EqualityComparer<T>.Default.Equals(pair.Key, key))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void CopyTo(KeyValuePair<T, G>[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (arrayIndex < 0 || arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }

            if (array.Length - arrayIndex < Count)
            {
                throw new ArgumentException("Insufficient space in the target array.");
            }

            foreach (var pair in _entries)
            {
                array[arrayIndex++] = pair;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<T, G>> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(T key)
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(_entries[i].Key, key))
                {
                    _entries.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(KeyValuePair<T, G> item)
        {
            return Contains(item) && Remove(item.Key);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(T key, [MaybeNullWhen(false)] out G value)
        {
            foreach (var pair in _entries)
            {
                if (EqualityComparer<T>.Default.Equals(pair.Key, key))
                {
                    value = pair.Value;
                    return true;
                }
            }
            value = default;
            return false;
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
