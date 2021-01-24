using System;

namespace HomeWork_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не знаю добавится этот проект сразу со всеми или надо будет отдльно каждый загружать, но если добвится, то он в 1 уже есть просто не такой полный
            //так же не понял как взять значение из проекта 2_1
            Console.ForegroundColor = ConsoleColor.Green;



            //float temperatyra;

            bool flag;
            int peredacha, mesac;

            do
            {
                Console.Write("Введите номер месяца: ");
                flag = Int32.TryParse(Console.ReadLine(), out peredacha);

            } while (flag == false);
            mesac = peredacha;



            //string[] mountList = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            //Console.WriteLine(mountList[mesac - 1]);

            switch (mesac)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Такого месяца нет -_-");
                    break;
            }

        }
    }
}
