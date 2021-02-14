using System;

namespace HomeWork_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            bool flag;
            float peredacha, max, min;
            
            do
            {
                Console.Write("Введите максимальную температуру в цельсиях за последние сутки: ");
                flag = float.TryParse(Console.ReadLine(), out peredacha);

            } while (flag == false);
            max = peredacha;
            
            
            do
            {
                Console.Write("Введите минимальную температуру в цельсиях за последние сутки: ");
                flag = float.TryParse(Console.ReadLine(), out peredacha);

            } while (flag == false);
            min = peredacha;

            float sred = (max + min) / 2;

            if (max < min) Console.WriteLine("Кажется вы перепутали максимальную с минимальной");

            Console.WriteLine($"Средняя температура: {sred}");


            #region Это 2 задание и дополнение к 1 и 2, а именно 5*

            int mesac, peredacha2;

            do
            {
                Console.Write("Введите номер месяца: ");
                flag = Int32.TryParse(Console.ReadLine(), out peredacha2);

            } while (flag == false);
            mesac = peredacha2;

            switch (mesac)
            {
                case 1:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Январь\nКак и должно быть, зима со снегом");
                    }
                    else
                    {
                        Console.WriteLine("Январь\nКакая-то неправильная зима, тёплая...");
                    }
                    break;
                case 2:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Февраль\nКак и должно быть, зима со снегом");
                    }
                    else
                    {
                        Console.WriteLine("Февраль\nКакая-то неправильная зима, тёплая...");
                    }
                    break;
                case 3:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Март\nНу как по мне снег в это время нормальное явление");
                    }
                    else
                    {
                        Console.WriteLine("Март\nНу где-то и слякоть нормальное яление...");
                    }
                    break;
                case 4:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Апрель\nНу как по мне снег в это время нормальное явление");
                    }
                    else
                    {
                        Console.WriteLine("Апрель\nНу где-то и слякоть нормальное яление...");
                    }
                    break;
                case 5:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Май\nНу как по мне снег в это время нормальное явление");
                    }
                    else
                    {
                        Console.WriteLine("Май\nА  кого-то уже за 30...");
                    }
                    break;
                case 6:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Июнь\nОооо да, походу вы тоже в этом райском месте...");
                    }
                    else
                    {
                        Console.WriteLine("Июнь\nНаконец у кого-то тепло в это время");
                    }
                    break;
                case 7:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Июль\nНу это уже даже для меня странно, если вы не на каком-то из полюсов...");
                    }
                    else
                    {
                        Console.WriteLine("Июль\nНадеюсь вы на море в это время");
                    }
                    break;
                case 8:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Август\nНу это уже даже для меня странно, если вы не на каком-то из полюсов...");
                    }
                    else
                    {
                        Console.WriteLine("Август\nВо Вьетнами в это время такой парняк...");
                    }
                    break;
                case 9:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Сентябрь\nЭто ужасное время для учащихся...");
                    }
                    else
                    {
                        Console.WriteLine("Сентябрь\nЭто ужасное время для учащихся...");
                    }
                    break;
                case 10:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Октябрь\nУ меня в городе по моей памяти снег уже был");
                    }
                    else
                    {
                        Console.WriteLine("Октябрь\nПохоже вы там где ещё в шортах можно ходить)");
                    }
                    break;
                case 11:
                    if (sred <= 0)
                    {
                        Console.WriteLine("Ноябрь\nКак и должно быть, зима со снегом");
                    }
                    else
                    {
                        Console.WriteLine("Ноябрь\nВы наверное с питера, тут снега вообще нет последние года, а если есть то растает быстро...");
                    }
                    break;
                case 12:
                    PrintToLog("Декабрь", sred);
                    break;
                default:
                    Console.WriteLine("Такого месяца нет -_-");
                    break;
            }

            #endregion

        }

        static void PrintToLog (string mount, float midl)
        {
            if (midl <= 0)
            {
                Console.WriteLine(mount+"\nКак и должно быть, зима со снегом");
            }
            else
            {
                Console.WriteLine(mount+"\nКакая-то неправильная зима, тёплая...");
            }
        }

    }
}
