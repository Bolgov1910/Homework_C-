// Задача №51 Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д. Например:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



using System;
 
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите размер массива N = ");
 
            int[] C = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = random.Next(-10, 30);
            }
            Console.WriteLine($"Исходный массив {string.Join(", ", C)}");
            int Sum = 0;
            for (int i = 1; i < C.Length; i += 2)
            {
                Sum += C[i];
            }
            Console.WriteLine($"Сумма элементов, имеющих нечетный порядковый номер равна {Sum}");
            Console.ReadLine();
        }
    }
}