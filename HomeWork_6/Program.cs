using System;
using System.Diagnostics;

namespace HomeWork_6
{
    class Program
    {
        //public void Kill();

        static int TopX(int leg)
        {
            int centerX;
            return centerX = (Console.WindowWidth / 2) - (leg / 2);

        }

        static int LineNumber = 1;


        static void Main(string[] args)
        {
            //Process[] processID = Process.GetProcessById(int proc);

            Console.ForegroundColor = ConsoleColor.Green;

            Process[] localAll = Process.GetProcesses();

            Console.WriteLine("Name                                      ID");

            for (int i = 0; i < localAll.Length; i++)
            {
                Console.WriteLine(localAll[i].ProcessName);
                Console.SetCursorPosition(TopX(36), LineNumber);
                Console.WriteLine(localAll[i].Id);
                LineNumber++;
            }

            Console.Write("\nВведите ID чтобы убить определённый процесс\nили названи, что б все одноимённые: ");

            string processID = Console.ReadLine();

            foreach (Process process in localAll)
            {
                if (Convert.ToString(process.Id) == processID || process.ProcessName ==  processID)
                {
                    process.Kill();
                    Console.WriteLine("Процесс " + process.ProcessName + " " + process.Id + " уничтожен)");
                }
            }


        }
    }
}
