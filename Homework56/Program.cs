// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов


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

// содаем массив
int[,] arr2D = Gen2DArr (row, colum, 0, 9); // заполнение числами от 0 до 9
// печать исходного
Print2DArr(arr2D);

int minSumLine = 0;                    // суммы элементов по строкам
int sumLine = SumLineElements(arr2D, 0);              
for (int i = 0; i < arr2D.GetLength(0)-1; i++)
{
  int tempSumLine = SumLineElements(arr2D, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;     // минимальное значение сохраняется
    minSumLine = i;               // сохранене индекса строки с минимальной суммой
  }
}
// метод - сумма элементов по строке с минимальной суммой элементов
int SumLineElements(int[,] array, int i)     
{
    int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}

Console.WriteLine($"\n{minSumLine} - строкa с наименьшей суммой элементов ({sumLine})  ");
