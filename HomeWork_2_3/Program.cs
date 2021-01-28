using System;

namespace HomeWork_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            bool flag;
            int peredacha, neizvestnaya;

            do
            {
                Console.Write("Введите число для определения чётности: ");
                flag = Int32.TryParse(Console.ReadLine(), out peredacha);

            } while (flag == false);
            neizvestnaya = peredacha;

            if ((neizvestnaya % 2) == 0)
            {
                Console.WriteLine("Введённое число является чётным");
            }
            else
            {
                Console.WriteLine("Введённое число является нечётным");
            }

        }
    }
}
