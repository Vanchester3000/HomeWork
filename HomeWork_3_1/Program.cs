using System;

namespace HomeWork_3_1
{
    class Program
    {

        static void Cleaning(string cleaning)
        {
            if (cleaning == "Clean" || cleaning == "clean")
            {
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            #region 1 задание

            //Не особо понял задание, надо вывести вообще все элементы по диагонали или как матрицу показать его...

            int[,] arrayDiagonal = new int[5, 5];
            Random rand = new Random();

            //как массив

            for (int i = 0; i < arrayDiagonal.GetLength(0); i++)
            {
                for (int j = 0; j < arrayDiagonal.GetLength(1); j++)
                {
                    arrayDiagonal[i, j] = rand.Next(10, 100);
                    Console.Write(arrayDiagonal[i, j] + "   ");
                }
                Console.WriteLine();
            }

            //по диагонали

            Console.WriteLine();

            for (int i = 0; i < arrayDiagonal.GetLength(0); i++)
            {
                for (int j = 0; j < arrayDiagonal.GetLength(1); j++)
                {
                    Console.WriteLine(arrayDiagonal[i, j] + "   ");
                }
            }

            #endregion

            Console.WriteLine("Если хотите очистить консоль введите: Clean");
            Cleaning(Console.ReadLine());

            #region 2 задание

            string[,] spravochnik = new string[5, 2];

            #region Данные массива

            spravochnik[0, 0] = "Иван      ";
            spravochnik[0, 1] = "+7(929)-945-44-33";
            spravochnik[1, 0] = "Мария     ";
            spravochnik[1, 1] = "+7(645)-684-64-97";
            spravochnik[2, 0] = "Евгений   ";
            spravochnik[2, 1] = "+7(255)-584-48-48";
            spravochnik[3, 0] = "Светлана  ";
            spravochnik[3, 1] = "+7(188)-845-18-97";
            spravochnik[4, 0] = "Владислав ";
            spravochnik[4, 1] = "+7(564)-987-99-32";

            #endregion

            for (int i = 0; i < spravochnik.GetLength(0); i++)
            {
                for (int j = 0; j < spravochnik.GetLength(1); j++)
                {
                    Console.Write(spravochnik[i, j]);
                }
                Console.WriteLine();
            }

            #endregion

            Console.WriteLine("\nДля повторной очистки введите: clean");
            Cleaning(Console.ReadLine());

            #region 3 задание

            Console.WriteLine("Введите текст который хотите отзеркалить: ");
            string zerkalo = Console.ReadLine();
            int leng = zerkalo.Length;

            for (int i = 0; i < leng; --leng)
            {
                Console.Write(zerkalo[leng - 1]);
            }

            #endregion

            Console.WriteLine("\nДля последней очистки введите: clean");
            Cleaning(Console.ReadLine());

            #region 4 задание

            string[,] sea_war = new string[11, 11];

            #region Данные массива

            // 1 строка
            // 2 столбец

            sea_war[0, 0] = "   "; sea_war[0, 1] = "А "; sea_war[0, 2] = "Б "; sea_war[0, 3] = "В "; sea_war[0, 4] = "Г "; sea_war[0, 5] = "Д "; sea_war[0, 6] = "Е "; sea_war[0, 7] = "Ж "; sea_war[0, 8] = "З "; sea_war[0, 9] = "И "; sea_war[0, 10] = "К";
            sea_war[1, 0] = " 1 "; sea_war[1, 1] = "X "; sea_war[1, 2] = "X "; sea_war[1, 3] = "O "; sea_war[1, 4] = "X "; sea_war[1, 5] = "O "; sea_war[1, 6] = "O "; sea_war[1, 7] = "X "; sea_war[1, 8] = "X "; sea_war[1, 9] = "X "; sea_war[1, 10] = "X";
            sea_war[2, 0] = " 2 "; sea_war[2, 1] = "O "; sea_war[2, 2] = "O "; sea_war[2, 3] = "O "; sea_war[2, 4] = "X "; sea_war[2, 5] = "O "; sea_war[2, 6] = "O "; sea_war[2, 7] = "O "; sea_war[2, 8] = "O "; sea_war[2, 9] = "O "; sea_war[2, 10] = "O";
            sea_war[3, 0] = " 3 "; sea_war[3, 1] = "O "; sea_war[3, 2] = "O "; sea_war[3, 3] = "O "; sea_war[3, 4] = "X "; sea_war[3, 5] = "O "; sea_war[3, 6] = "O "; sea_war[3, 7] = "O "; sea_war[3, 8] = "O "; sea_war[3, 9] = "O "; sea_war[3, 10] = "X";
            sea_war[4, 0] = " 4 "; sea_war[4, 1] = "O "; sea_war[4, 2] = "O "; sea_war[4, 3] = "O "; sea_war[4, 4] = "O "; sea_war[4, 5] = "O "; sea_war[4, 6] = "O "; sea_war[4, 7] = "O "; sea_war[4, 8] = "O "; sea_war[4, 9] = "O "; sea_war[4, 10] = "X";
            sea_war[5, 0] = " 5 "; sea_war[5, 1] = "O "; sea_war[5, 2] = "X "; sea_war[5, 3] = "O "; sea_war[5, 4] = "O "; sea_war[5, 5] = "O "; sea_war[5, 6] = "O "; sea_war[5, 7] = "O "; sea_war[5, 8] = "O "; sea_war[5, 9] = "O "; sea_war[5, 10] = "O";
            sea_war[6, 0] = " 6 "; sea_war[6, 1] = "O "; sea_war[6, 2] = "X "; sea_war[6, 3] = "O "; sea_war[6, 4] = "O "; sea_war[6, 5] = "O "; sea_war[6, 6] = "O "; sea_war[6, 7] = "X "; sea_war[6, 8] = "O "; sea_war[6, 9] = "O "; sea_war[6, 10] = "O";
            sea_war[7, 0] = " 7 "; sea_war[7, 1] = "O "; sea_war[7, 2] = "X "; sea_war[7, 3] = "O "; sea_war[7, 4] = "O "; sea_war[7, 5] = "O "; sea_war[7, 6] = "O "; sea_war[7, 7] = "O "; sea_war[7, 8] = "O "; sea_war[7, 9] = "O "; sea_war[7, 10] = "O";
            sea_war[8, 0] = " 8 "; sea_war[8, 1] = "O "; sea_war[8, 2] = "O "; sea_war[8, 3] = "O "; sea_war[8, 4] = "O "; sea_war[8, 5] = "O "; sea_war[8, 6] = "O "; sea_war[8, 7] = "O "; sea_war[8, 8] = "O "; sea_war[8, 9] = "O "; sea_war[8, 10] = "O";
            sea_war[9, 0] = " 9 "; sea_war[9, 1] = "O "; sea_war[9, 2] = "O "; sea_war[9, 3] = "O "; sea_war[9, 4] = "X "; sea_war[9, 5] = "O "; sea_war[9, 6] = "X "; sea_war[9, 7] = "O "; sea_war[9, 8] = "O "; sea_war[9, 9] = "X "; sea_war[9, 10] = "O";
            sea_war[10, 0] = "10 "; sea_war[10, 1] = "X "; sea_war[10, 2] = "O "; sea_war[10, 3] = "O "; sea_war[10, 4] = "O "; sea_war[10, 5] = "O "; sea_war[10, 6] = "O "; sea_war[10, 7] = "O "; sea_war[10, 8] = "O "; sea_war[10, 9] = "X "; sea_war[10, 10] = "O";


            #endregion

            for (int i = 0; i < sea_war.GetLength(0); i++)
            {
                for (int j = 0; j < sea_war.GetLength(1); j++)
                {
                    Console.Write(sea_war[i, j]);
                }
                Console.WriteLine();
            }

            #endregion

        }
    }
}
