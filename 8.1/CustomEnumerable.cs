using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{

    public class FibonacciSequence : IEnumerable<int>
    {
        /// <summary>
        /// Кол-во чисел
        /// </summary>
        private readonly int _count; // Количество элементов в последовательности
        /// <summary>
        /// Полседовательность фибоначи
        /// </summary>
        /// <param name="count"></param>
        public FibonacciSequence(int count) => _count = count;
        /// <summary>
        /// еализуем интефейс
        /// </summary>
        /// <returns></returns>
        public IEnumerator<int> GetEnumerator() => new FibonacciEnumerator(_count);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        /// <summary>
        /// Реализация IEnumerator
        /// </summary>
        private class FibonacciEnumerator : IEnumerator<int>
        {
            /// <summary>
            ///  Количество элементов
            /// </summary>
            private readonly int _count;
            /// <summary>
            /// Текущий индекс
            /// </summary>
            private int _currentIndex = -1;
            /// <summary>
            /// Текущее значение
            /// </summary>
            private int _current = 0;
            /// <summary>
            /// Предыдущее значение
            /// </summary>
            private int _previous = 1; 
            /// <summary>
            /// Энумератор
            /// Энумератор
            /// </summary>
            /// <param name="count"></param>
            public FibonacciEnumerator(int count) => _count = count;
            /// <summary>
            /// Текущий элемнт
            /// </summary>
            public int Current => _current;
            /// <summary>
            /// 
            /// </summary>
            object IEnumerator.Current => Current;
            /// <summary>
            /// Двигаемся вперед(можно ли еще двигатоься)
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (_currentIndex >= _count - 1)
                    return false;

                _currentIndex++;
                if (_currentIndex == 0)
                {
                    _current = 0;
                }
                else if (_currentIndex == 1)
                {
                    _current = 1;
                }
                else
                {
                    int temp = _current;
                    _current += _previous;
                    _previous = temp;
                }

                return true;
            }
            /// <summary>
            /// Начать заново
            /// </summary>
            public void Reset()
            {
                _currentIndex = -1;
                _current = 0;
                _previous = 1;
            }
            /// <summary>
            /// Просто реализуем интерфейс
            /// </summary>
            public void Dispose()
            {
                // Ничего не нужно освобождать
            }
        }
    }
}
