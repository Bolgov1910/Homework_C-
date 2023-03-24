


int[,] a = new int[10, 10];
Console.Write("Введи количество строк в массиве  n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов в массиве  m=");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("a[" + i + "," + j + "]=");
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Вывод двумерного массива");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++) Console.Write("{0,9}", a[i, j]);
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
for (int j = 0; j < m; j++)
if (i%2 = 0) i++;
    {
        a[i, j] = 6;
    }
Console.WriteLine();
Console.ReadKey();
