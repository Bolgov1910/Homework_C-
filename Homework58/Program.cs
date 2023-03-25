// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц. 
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}

// метод заполнения - универсальный
int[,] Gen2DArr(int countRow, int countColumn, int min, int max) // кол-во строк, кол-во столбцов
{
    if (min>max) // это для того, чтобы поменять числа местами, если min оказалость больше max
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random(); // создается один генератор случайных чисел c именем rnd
    int[,] arr = new int[countRow,countColumn]; // двумерный массив - ко-во строк и столбцов
    for (int i=0; i< countRow; i++)
    {
        for (int j=0; j< countColumn; j++)
        {
            arr[i,j] =  rnd.Next(min,max+1); // +1 - последнее число в интервал не входит
        }
        
    }
    return arr;
}

// метод: печать
void Print2DArr(int[,] arr) 
{   
    for (int i = 0; i < arr.GetLength(0); i++)   // arr.GetLength- измеряет здесь-измерение"0"-строки ; элементы массива (-1) - без последнего элемента 
    {
        for (int j = 0; j < arr.GetLength(1); j++)   // arr.GetLength- измеряет здесь-измерение"1"-столбцы
        {
            Console.Write(arr[i,j] + " ");  // элемент массива + пробел
        }    
        Console.WriteLine(); // первод на новую строку
    }
}  

// Работа
int row = ReadData ("Введите количество строк:");
int colum = ReadData ("Введите количество столбцов:");

// содаем массив - 2 матрицы одним методом
int[,] arr2Dnun1 = Gen2DArr (row, colum, 0, 9); // заполнение числами от 0 до 9
int[,] arr2Dnun2 = Gen2DArr (row, colum, 0, 9); // заполнение числами от 0 до 9
// печать исходных матриц через пустую строку
Print2DArr(arr2Dnun1);
Console.WriteLine();
Print2DArr(arr2Dnun2);

int[,] resultMatrix = new int[row,colum];  // новая матрица
// Умножает структуру Matrix на другую структуру Matrix  -https://learn.microsoft.com/ru-ru/dotnet/api/system.windows.media.matrix.multiply?view=windowsdesktop-7.0	
MultiplyMatrix(arr2Dnun1, arr2Dnun2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");

// Печать результата тем же методом
Print2DArr(resultMatrix);


// Метод - умножение матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
	
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
	
