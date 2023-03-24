// хххЗадача №48 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите 
// ххх полученный массив на экран.


// Дан двумерный массив размерностью 4 х 6, заполненный целыми числами с клавиатуры. 
//Сформировать одномерный массив, каждый элемент которого равен количеству 
//элементов соответствующей строки, больших данного числа


using System;
using System.Linq;
                    
public class Program
{
    public static void Main()
    {
        int num = 0;
        int[][] matr = new int[4][];
        for (int i = 0; i < matr.Length; i++)
            matr[i] = new int[6];
        int[] arr = new int[matr.Length];
        
        Console.WriteLine("Заполните матрицу:");
        for (int i = 0; i < matr.Length; i++)
        {
            for (int j = 0; j < matr[i].Length; j++)
            {
                Console.Write("Введите значение элемента {0}-й строки {1}-го столбца: ", i + 1, j + 1);
                matr[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("Введите число: ");
        num = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < arr.Length; i++)
            arr[i] = matr[i].Where(it => it > num).Count();
        
        Console.Write("Полученный массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != arr.Length - 1)
                Console.Write("{0} ", arr[i]);
            else
                Console.WriteLine(arr[i]);
        }
    }
}