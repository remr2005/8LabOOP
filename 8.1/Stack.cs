using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    public class MyQueue<T> : ICollection<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        // Свойство для получения количества элементов в очереди
        public int Count => _list.Count;

        // Свойство, которое всегда возвращает false (очередь не поддерживает интерфейс IReadOnlyCollection)
        public bool IsReadOnly => false;

        // Метод добавления элемента в очередь (аналог enqueue)
        public void Add(T item)=> _list.AddLast(item); // Элементы добавляются в конец списка
        
        public void Enqueue(T item) => Add(item);
        // Метод для очистки очереди
        public void Clear()=> _list.Clear();

        // Метод для проверки наличия элемента в очереди
        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        // Метод для копирования элементов в массив
        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        // Метод для удаления одного экземпляра элемента (аналог dequeue)
        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        // Метод для получения и удаления первого элемента очереди
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста.");
            }

            T value = _list.First.Value;
            _list.RemoveFirst();
            return value;
        }

        // Метод для получения первого элемента очереди без удаления
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста.");
            }

            return _list.First.Value;
        }

        // Итератор для очереди
        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        // Для совместимости с ICollection (необходимо для коллекций на основе IEnumerable)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class MyStack<T> : ICollection<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        // Свойство для получения количества элементов в стеке
        public int Count => _list.Count;

        // Свойство, которое всегда возвращает false (стек не поддерживает интерфейс IReadOnlyCollection)
        public bool IsReadOnly => false;

        // Метод добавления элемента в стек (аналог push)
        public void Add(T item) => _list.AddFirst(item); // Элементы добавляются в начало списка


        public void Push(T item) => Add(item);

        // Метод для очистки стека
        public void Clear() => _list.Clear();

        // Метод для проверки наличия элемента в стеке
        public bool Contains(T item) => _list.Contains(item);

        // Метод для копирования элементов в массив
        public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);
        // Метод для удаления одного экземпляра элемента (аналог pop)
        public bool Remove(T item) => _list.Remove(item);

        // Метод для получения и удаления верхнего элемента стека
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Стек пуст.");
            }

            T value = _list.First.Value;
            _list.RemoveFirst();
            return value;
        }

        // Метод для получения верхнего элемента стека без удаления
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Стек пуст.");
            }

            return _list.First.Value;
        }

        // Итератор для стека
        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();
        // Для совместимости с ICollection (необходимо для коллекций на основе IEnumerable)
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
