using System;
using System.IO;
using System.Text.Json;

namespace HomeWork_5_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            #region 1 задание

            string text = "произвольный набор данных";
            File.WriteAllText("startup.txt", text);

            #endregion

            #region 2 задание

            DateTime time = DateTime.Now;

            File.AppendAllText("startup.txt", Environment.NewLine + time.ToString("HH:mm:ss"));

            #endregion

            #region 3 задание

            Console.WriteLine("Введите 5 значений от 0 до 255 включительно");
            byte[] arr = new byte[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToByte(Console.ReadLine());
            }
            File.WriteAllBytes("bytes.bin", arr);

            byte[] fromFile = File.ReadAllBytes("bytes.bin");

            Console.WriteLine(fromFile);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            File.WriteAllBytes("bytes.bin", arr);

            #endregion

            #region *4 задание

            string PathToFolder = @"D:\Проекты в С# и Unity\C#\С# проекты\Проекты с Git\HomeWork\HomeWork_5_1\bin\Debug\netcoreapp3.1";
            string[] allfiles = Directory.GetFiles(PathToFolder);
            foreach (string filename in allfiles)
            {
                Console.WriteLine(filename);
                File.AppendAllText("файлы.txt", filename + Environment.NewLine);
            }

            #endregion

            #region *5 задание
            // ошибка при дессериализации
            #region Сериализация
            ToDo task1 = new ToDo(1, "проснуться", false);
            ToDo task2 = new ToDo(2, "поесть", true);
            ToDo task3 = new ToDo(3, "поучиться", true);
            ToDo task4 = new ToDo(4, "покупаться", true);
            ToDo task5 = new ToDo(5, "поесть", true);
            ToDo task6 = new ToDo(6, "почитать", true);
            ToDo task7 = new ToDo(7, "поесть", true);
            ToDo task8 = new ToDo(8, "посмотреть видосы", false);
            ToDo task9 = new ToDo(9, "поесть", false);
            ToDo task10 = new ToDo(10, "поспать", false);

            string serialization = "Сериализация.txt";

            string spJson1 = JsonSerializer.Serialize(task1);
            string spJson2 = JsonSerializer.Serialize(task2);
            string spJson3 = JsonSerializer.Serialize(task3);
            string spJson4 = JsonSerializer.Serialize(task4);
            string spJson5 = JsonSerializer.Serialize(task5);
            string spJson6 = JsonSerializer.Serialize(task6);
            string spJson7 = JsonSerializer.Serialize(task7);
            string spJson8 = JsonSerializer.Serialize(task8);
            string spJson9 = JsonSerializer.Serialize(task9);
            string spJson10 = JsonSerializer.Serialize(task10);

            File.AppendAllText(serialization, spJson1);
            File.AppendAllText(serialization, spJson2);
            File.AppendAllText(serialization, spJson3);
            File.AppendAllText(serialization, spJson4);
            File.AppendAllText(serialization, spJson5);
            File.AppendAllText(serialization, spJson6);
            File.AppendAllText(serialization, spJson7);
            File.AppendAllText(serialization, spJson8);
            File.AppendAllText(serialization, spJson9);
            File.AppendAllText(serialization, spJson10);

            #endregion

            Console.Clear();

            #region Десериализация

            string deJson = File.ReadAllText(serialization);
            ToDo[] toDoArray = JsonSerializer.Deserialize<ToDo[]>(deJson);
            for (int i = 0; i < toDoArray.Length; i++)
            {
                Console.WriteLine($"{toDoArray[i].Number} {toDoArray[i].Number} {toDoArray[i].Flag}");
            }

            #endregion

            #endregion

        }
    }
}
