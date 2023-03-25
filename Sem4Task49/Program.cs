// Задача №49 Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты. Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
    // создается один генератор цветов (массив) c именем col ; есть 16 цветов - https://learn.microsoft.com/ru-ru/dotnet/api/system.consolecolor?view=net-7.0#system-consolecolor-red
    ConsoleColor [] col = new ConsoleColor[] {ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.DarkRed};
    for (int i = 0; i < arr.GetLength(0); i++)   // arr.GetLength- измеряет здесь-измерение"0"-строки ; элементы массива (-1) - без последнего элемента 
    {
        for (int j = 0; j < arr.GetLength(1); j++)   // arr.GetLength- измеряет здесь-измерение"1"-столбцы
        {
            Console.ForegroundColor = col[new Random().Next(0,3)];   // вызов метода цвета шрифта. случайный выбор из заданных
            Console.Write(arr[i,j] + " ");  // элемент массива + пробел
            Console.ResetColor(); // сброс цвета 
        }    
        Console.WriteLine(); // первод на новую строку
    }
}  

// метод: обработка
void Update2DArr(int[,] arr) // на входе двумерный массив
{
    for (int i = 0; i<arr.GetLength(0); i++) // i от 0 до длины масива (измерение 0 -строки)
    {
        for (int j = 0; j<arr.GetLength(1); j++) // i от 0 до длины масива (измерение 1 -столбцы)
        {
            if (i%2==0 && j%2==0)
            {
                arr[i, j] *= arr[i, j];
                //Console.Write(arr[i,j] + " ");  // печать элемента массива + пробел
            }
        }
        //Console.ResetColor(); // сброс цвета 
    }
}

// Работа:
// Ввод количества строк и столбцов
int row = ReadData ("Введите количество строк:");
int colum = ReadData ("Введите количество столбцов:");

// содаем массив
int[,] arr2D = Gen2DArr (row, colum, 1, 9); // заполнение числами от 1 до 9
// печать массива
Print2DArr(arr2D); 
// обработка массива
Console.WriteLine(); // пробел -строка
Update2DArr (arr2D);
// печать обработанного массива
Print2DArr(arr2D); 
