using System;

namespace AndersenTasks
{
    class Program
    {
        /// <summary>
        /// Составить алгоритм: если введенное число больше 7, то вывести “Привет”
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {          
            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n > 7)
                    {
                        Console.WriteLine("Привет");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите число больше 7");
                    }
                }
                catch (Exception p)
                {
                    Console.WriteLine("Некорретный ввод! Введите число");
                }
            }
            //Console.ReadKey();
        }
    }
}
