// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

// метод работы - упорядочит по убыванию элементы каждой строки 
// Комментарий к ДЗ "В 54 задаче Вы встроили сортировку в метод OrderArrayLines, 
// это нарушение принципов SOLID(OCP и SRP). 
// Если по каким-то причинам предется поменять сортировку, придется менять метод."
// ЛУЧШЕ БЕЗ МЕТОДА
void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++) // по столбцам
	    {
	        for (int k = 0; k < array.GetLength(1) - 1; k++) // элементы строки
	        {
	            if (array[i, k] < array[i, k + 1])  // если элемент < следующего
	            {
	                int temp = array[i, k + 1];     //  следующий ложится в temp
	                array[i, k + 1] = array[i, k];   // текущий передвиеается в следующий
	                array[i, k] = temp;              // в текуший из temp кладется следующий
	            }
	        }
	    }
	}
}
	
// Работа
int row = ReadData ("Введите количество строк:");
int colum = ReadData ("Введите количество столбцов:");

// содаем массив
int[,] arr2D = Gen2DArr (row, colum, 10, 99); // заполнение числами от 10 до 99
// печать исходного
Print2DArr(arr2D);
Console.WriteLine(); // пропуск строки
// Обработка
OrderArrayLines (arr2D);
// Печать массива с отсортированными эсементами строк
Print2DArr(arr2D);
