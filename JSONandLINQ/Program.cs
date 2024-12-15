using Newtonsoft.Json;
using System;

namespace JSONandLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass[] array = new SomeClass[10];
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                array[i] = new SomeClass(rand.Next(), rand.Next().ToString());
            }
            var LINQExample = from clss in array
                              where clss != null
                              where clss.number > 3
                              select clss;
            foreach (var clss in LINQExample)
            {
                Console.WriteLine("Сериализованный JSON:");
                string json = JsonConvert.SerializeObject(clss);
                Console.WriteLine(json);
                SomeClass deserializedPerson = JsonConvert.DeserializeObject<SomeClass>(json);
                Console.WriteLine("Десериализованный объект:");
                Console.WriteLine($"Name: {deserializedPerson.number}, Age: {deserializedPerson.str}\n");
            }
        }
    }
}