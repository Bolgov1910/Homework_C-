// Задача №46 Задайте двумерный массив размером m×n, заполненный 
//случайными целыми числами.


int rows = 4, columns = 6;
var arr = new int[rows, columns];
var rnd = new Random();
var result = new int[rows];

//fill array
for(int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = rnd.Next(0, 20); //Convert.ToInt32(Console.ReadLine());
    }
}
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
 
for(int i = 0; i < rows; i++)
{
int cnt = 0;
    for (int j = 0; j < columns; j++)
    {
        if (arr[i, j] > x) cnt++;
    }
    result[i] = cnt;
}
 
            Console.ReadLine();