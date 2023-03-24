// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Метод заполнения массива случайными вещественными числами от -100 до 100
double[,] FillMatrix(int rows, int cols)
{
    double [,] array = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
    return array;
}
// Ввод
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

// Метод	
void FillArrayRandomNumbers(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
	    for (int j = 0; j < array.GetLength(1); j++)
	    {
	        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
	    }
	}
}
	
// Печать
void PrintArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
	    Console.Write("[ ");
	    for (int j = 0; j < array.GetLength(1); j++)
	    {
	        Console.Write(array[i, j] + " ");
	    }
	    Console.Write("]");
	    Console.WriteLine("");
	}
}
