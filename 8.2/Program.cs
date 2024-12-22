using System;
using System.Diagnostics;

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
            customDict.Add("Charlie", 40);

            // Измерение времени для поиска по ключу
            Stopwatch stopwatch = new Stopwatch();

            // Измерим время на поиск ключа 'Alice'
            stopwatch.Start();
            var valueAlice = customDict["Alice"]; // Доступ через индексатор
            stopwatch.Stop();
            Console.WriteLine($"Время доступа к 'Alice' через индексатор: {stopwatch.ElapsedTicks} тактов.");

            // Измерим время на проверку наличия ключа
            stopwatch.Reset();
            stopwatch.Start();
            bool containsBob = customDict.ContainsKey("Bob");
            stopwatch.Stop();
            Console.WriteLine($"Время проверки наличия ключа 'Bob': {stopwatch.ElapsedTicks} тактов.");

            // Измерим время на доступ через TryGetValue
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(customDict["Bob"]);
            stopwatch.Stop();
       
            Console.WriteLine($"Время доступа к 'Bob': {stopwatch.ElapsedTicks} тактов.");

            // Вывод всех ключей и значений
            Console.WriteLine("\nСодержимое CustomDict:");
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
