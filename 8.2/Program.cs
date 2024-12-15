using System;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра CustomDict
            CustomDict<string, int> customDict = new CustomDict<string, int>();

            // Добавление элементов
            customDict.Add("Alice", 30);
            customDict.Add("Bob", 25);

            // Использование индексатора
            customDict["Charlie"] = 40; // Добавление нового элемента
            customDict["Alice"] = 35;   // Обновление значения

            // Вывод всех ключей и значений
            Console.WriteLine("Содержимое CustomDict:");
            foreach (var pair in customDict)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            // Проверка наличия ключа
            Console.WriteLine("\nПроверка наличия ключей:");
            Console.WriteLine($"Contains 'Alice': {customDict.ContainsKey("Alice")}");
            Console.WriteLine($"Contains 'Diana': {customDict.ContainsKey("Diana")}");

            // Получение значения с помощью TryGetValue
            Console.WriteLine("\nПолучение значения:");
            if (customDict.TryGetValue("Bob", out int value))
            {
                Console.WriteLine($"Value for 'Bob': {value}");
            }
            else
            {
                Console.WriteLine("'Bob' не найден.");
            }

            // Удаление элемента
            Console.WriteLine("\nУдаление 'Alice':");
            customDict.Remove("Alice");

            // Вывод после удаления
            Console.WriteLine("Содержимое после удаления:");
            foreach (var pair in customDict)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.WriteLine("Умный массив");
            SmartArray smartArray = new SmartArray(5);

            smartArray[0] = 10;
            smartArray[1] = 20;

            Console.WriteLine("Содержимое массива:");
            foreach (var item in smartArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Массив содержит значение 20: {smartArray.Contains(20)}");

        }
    }
}
