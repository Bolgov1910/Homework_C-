// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
//каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}

// Метод - создание 3-х мерного массива 
void CreateArray(int[,,] array3D)
{
  // создание 1-мерного массива (списка) из неповторяющихся чисел, равного по количеству элементов создаваемому массиву
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)]; // одномерный массив с длиной = размеру массива (= X*Y*Z)
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100); // случайное число вводим в temp
    number = temp[i];                     // сохранение числа
    if (i >= 1)                            // для следующих строк - 1 измерение
    {
        for (int j = 0; j < i; j++)          // по столбцам - 2 измерение
        {
        while (temp[i] == temp[j])            //  до тех пор, пока новое число совпадает с уже введенным
        {
            temp[i] = new Random().Next(10, 100);  // следующее случайное число
            j = 0;
            number = temp[i];
        }
            number = temp[i];                    // сохранение числа
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)  // по 1 измерению
  {
    for (int y = 0; y < array3D.GetLength(1); y++)    // по 2 измерению
    {
      for (int z = 0; z < array3D.GetLength(2); z++)    // по 3 измерению
      {
        array3D[x, y, z] = temp[count];    // из соданного списка уникальных чисел заполняем массив
        count++;
      }
    }
  }
}
// метод печати 3-мерного массива
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++) // по 1 измерению
  {
    for (int j = 0; j < array3D.GetLength(1); j++)   // по 2 измерению
    {
      Console.Write($"X({i}) Y({j}) ");               // на печать значения x и Y
      for (int k = 0; k < array3D.GetLength(2); k++)    // по 3 измерению
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");   // на печать значени z и элемента
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


// Ввод количества строк и столбцов
int x = ReadData ("Введите размер 1:");
int y = ReadData ("Введите размер 2:");
int z = ReadData ("Введите размер 3:");
// создаем строку для загрузки в метод создания 3-х мерного массива 
int[,,] array3D = new int[x, y, z];
// запуск создания 3-х мерного массива 
CreateArray(array3D);
// на печать
WriteArray(array3D);

