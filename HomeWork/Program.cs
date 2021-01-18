using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            DateTime now = DateTime.Now;

            Console.WriteLine("Здравствуйте " + name + ", меня зовут Иван)\nНа момент выполнения дз было: 17.01.2021 13:21:38\nА просмотр дз сделан: " + now);
            Console.ReadLine();
        }
    }
}