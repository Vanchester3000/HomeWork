using System;
using System.Collections.Generic;

namespace HomeWork_4_1
{
    class Program
    {

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }

        static void Cleaning(string cleaning)
        {
            if (cleaning == "Clean" || cleaning == "clean")
            {
                Console.Clear();
            }
        }
        enum Season
        {
            None, Winter, Spring, Summer, Autum
        }


        static int Fibbonachi(int n/*, int[] results*/)
        {

            //if (n == 0)
            //    return results[0];
            //if (n == 1)
            //    return results[1];
            //if(results[n] != 0)
            //{
            //    results[n] = Fibbonachi(n - 2, results) + Fibbonachi(n - 1, results);
            //}
            //return results[n];
            return (n == 1 || n == 0) ? 1 : Fibbonachi(n - 1) + Fibbonachi(n - 2);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            #region 1 задание

            string[] fio = { "Иванов", "Александр", "Александрович", "Крюкова", "Ольга", "Петровна", "Дудник", "Андрей", "Романович", "Медведев", "Дмитрий", "Анатольевич", "Тринкер", "Борис", "Давидович" };

            for (int i = 0; i < fio.Length; i += 3)
            {
                Console.WriteLine(GetFullName(fio[i], fio[i + 1], fio[i + 2]));
            }

            #endregion

            Console.WriteLine("\nЕсли хотите очистить консоль введите: Clean");
            Cleaning(Console.ReadLine());

            #region 2 задание

            Console.WriteLine("Введите числа через пробел");
            string rowNumbers = Console.ReadLine();
            string[] numbers = rowNumbers.Split(' ');

            ulong sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + ulong.Parse(numbers[i]);
            }

            Console.WriteLine(sum);

            #endregion

            Console.WriteLine("\nДля повторной очистки введите: clean");
            Cleaning(Console.ReadLine());

            #region 3 Задание

            Season sea = Season.None;
            int seasonNumber = Convert.ToInt32(Console.ReadLine());
            switch (seasonNumber)
            {
                case 1:
                case 2:
                case 12:
                    sea = Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    sea = Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    sea = Season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    sea = Season.Autum;
                    break;
                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;
            }
            Console.WriteLine(sea);

            #endregion

            Console.WriteLine("\nДля последней очистки введите: clean");
            Cleaning(Console.ReadLine());

            #region 4 Задание

            DateTime start = DateTime.Now;
            int input = int.Parse(Console.ReadLine());
            int[] results = new int[input+1];
            Console.WriteLine(Fibbonachi(input/*, results*/));
            DateTime finish = DateTime.Now;
            Console.WriteLine("Время выполнения подсчётов: " + (finish - start));

            //Console.ReadLine();


            //Чё т рекурсия быстро заполняет стек, мне не понравилась она

            //ulong n = ulong.Parse(Console.ReadLine());
            //DateTime start = DateTime.Now;

            //ulong num1 = 0;
            //ulong num2 = 1;
            //ulong sum = 1;

            //for (ulong i = 0; i < n; i++)
            //{

            //    sum = num1 + num2;
            //    num1 = num2;
            //    num2 = sum;

            //}


            //Console.WriteLine(num2);
            //DateTime finish = DateTime.Now;
            //Console.WriteLine("Время выполнения подсчётов: " + (finish - start));

            #endregion


        }
    }
}
