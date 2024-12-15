using System.Linq;

namespace _8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример работы с CustomCollection
            Console.WriteLine("Работа с CustomCollection:");
            var collection = new CustomArray<object>();
            collection.Add(10);
            collection.Add("Hello");
            collection.Add(3.14);
            collection.Sort(); // Для сортировки разнородных объектов потребуется кастомный Comparer
            Console.WriteLine($"Количество элементов в коллекции: {collection.Count}");
            foreach (var item in collection)
            {
                Console.WriteLine($"Элемент: {item}");
            }
            // Пример работы с CustomEnumerable
            var fibonacci = new FibonacciSequence(10);

            Console.WriteLine("Последовательность Фибоначчи:");
            foreach (var number in fibonacci)
            {
                Console.Write(number + " ");
            }
        }
    }
}