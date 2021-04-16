using System;
using System.Text;

namespace AndersenTask3
{
    class Program
    {
        /// <summary>
        /// Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] mas= new int[5];
           
            while (true)
            {
                try
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        Console.Write("Введите число, которое будет записано в массив: ");
                        mas[i] = Convert.ToInt32(Console.ReadLine());                 
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (mas[i] % 3 == 0)
                        {
                            Console.WriteLine("Число кратное 3: " + mas[i]);
                        }                        
                    }
                    break;
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
