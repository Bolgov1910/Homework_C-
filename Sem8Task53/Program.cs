// Задача №53 Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

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
            Console.ForegroundColor = col[new Random().Next(1,3)];   // вызов метода цвета шрифта. случайный выбор из заданных
            Console.Write(arr[i,j] + " ");  // элемент массива + пробел
            Console.ResetColor(); // сброс цвета 
        }    
        Console.WriteLine(); // первод на новую строку
    }
}  

// Метод - замена строк: первой и последней - участвуют только 1 и последняя строки
void Change2Darr (int[,] matr)
{
    int temp = 0; // временная переменная
    for (int i=0; i<matr.GetLength(1); i++) // c первого столбца (размер-измерение1-столбцы) 
    {
        // !! работает (matr[0,i],matr[matr.GetLength(0)-1,i]) = (matr[matr.GetLength(0)-1,i],matr[0,i]) - прямая замена
        temp = matr[0,i];                         // в буфер
        matr [0,i] = matr [matr.GetLength(0)-1,i];      // из последней строки в первую
        matr [matr.GetLength(0)-1,i] = temp;           // из буфера в последнюю
    }
}

int row = ReadData ("Введите количество строк:");
int colum = ReadData ("Введите количество столбцов:");
// содаем массив
int[,] arr2D = Gen2DArr (row, colum, 10, 99); // заполнение числами от 10 до 99
// печать массива
Print2DArr (arr2D);
Console.WriteLine(); // пустая строка
// обработка массива
Change2Darr (arr2D);
// печать массива после обработки
Print2DArr (arr2D);