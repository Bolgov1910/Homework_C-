// Задача №48 Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите 
// полученный массив на экран.
// ОТ ЗАДАЧИ 46 ОТЛИЧАЕТСЯ СТРОКОЙ 27 (заполнение) и СТР 44 (печать с табуляцией)
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
            arr[i,j] =  i+j; // тупо суммируем, хотя надо было (i+1) + (j+1), т.к. m и n - это размер, а не позиция
        }
        
    }
    return arr;
}

// метод: печать
void Print2DArr(int[,] arr) 
{   
    // создается один генератор цветов (массив) c именем col ; есть 16 цветов - https://learn.microsoft.com/ru-ru/dotnet/api/system.consolecolor?view=net-7.0#system-consolecolor-red
    ConsoleColor [] col = new ConsoleColor[] {ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.DarkRed};
    for (int i = 0; i < arr.GetLength(0); i++)   // arr.GetLength- измеряет здесь-измерение"0"-строки ; элементы массива (-1) - без последнего элемента 
    {
        for (int j = 0; j < arr.GetLength(1); j++)   // arr.GetLength- измеряет здесь-измерение"1"-столбцы
        {
            Console.ForegroundColor = col[new Random().Next(0,3)];   // вызов метода цвета шрифта. случайный выбор из заданных
            Console.Write($"{arr[i,j]}\t ");  // элемент массива c табуляцией
            Console.ResetColor(); // сброс цвета 
        }    
        Console.WriteLine(); // первод на новую строку
    }
}  

// Работа:
// Ввод количества строк и столбцов
int row = ReadData ("Введите количество строк:");
int colum = ReadData ("Введите количество столбцов:");

// содаем массив
int[,] arr2D = Gen2DArr (row, colum, 10, 99); // заполнение числами от 10 до 99

Print2DArr(arr2D);


