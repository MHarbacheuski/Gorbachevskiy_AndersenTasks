using System;

namespace AndersedTask2
{
    class Program
    {
        /// <summary>
        /// Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {           
            while (true)
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                if (name == "Вячеслав")
                {
                    Console.WriteLine("Привет Вячеслав");
                    break;
                }
                else
                {
                    Console.WriteLine("Нет такого имени");
                }
            }
        }
    }
}
