// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Метод печати с эстетикой
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] / 10 <= 0)               // если число имеет 1 знак - перед ним добавляется пробел
        Console.Write($" {array[i,j]} ");
        else Console.Write($"{array[i,j]} ");   // двухзначные числа 
    }
    Console.WriteLine();
  }
}

// Метод печати с табуляцией
void Print2DArr(int[,] arr) 
{   
    for (int i = 0; i < arr.GetLength(0); i++)   // arr.GetLength- измеряет здесь-измерение"0"-строки ; элементы массива (-1) - без последнего элемента 
    {
        for (int j = 0; j < arr.GetLength(1); j++)   // arr.GetLength- измеряет здесь-измерение"1"-столбцы
        {
            Console.Write($"{arr[i,j]}\t");  // элемент массива + пробел
        } 
        Console.WriteLine(); // первод на новую строку
    }
}  


// Работа
// новый массив 4 х 4
int[,] arr2D = new int[4, 4];

int temp = 1; // начинаем с 1
int i = 0;
int j = 0;
// заполнение
while (temp <= arr2D.GetLength(0) * arr2D.GetLength(1)) // пока не заполним все элементы(16шт)
{
arr2D[i, j] = temp;                                // 1 в 1-ю позицию (0,0)
temp++;                                            // увеличиваем число на 1
if (i <= j + 1 && i + j < arr2D.GetLength(1) - 1)  // пока строка не кончится заполняем ее
    j++;
else 
    if (i < j && i + j >= arr2D.GetLength(0) - 1) // следующая строка - остаемся в последней колонке, вниз до конца
    {
        i++;
    }
    else 
        if (i >= j && i + j > arr2D.GetLength(1) - 1)  // поворот влево по нижней строке до упора
        {
            j--;
        }
    else
    i--;                                              // поворот вверх по первой колонке 
}


// Запуск печати с эстетикой
WriteArray(arr2D);
// Запуск печати с табуляцией
Print2DArr (arr2D);