// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}

// Метод -  вывода данных - создание
void PrintQuiter (int X, int Y)
{
    if (X>0 && Y>0) Console.WriteLine("1-я четверть");
    if (X>0 && Y<0) Console.WriteLine("2-я четверть");
    if (X<0 && Y<0) Console.WriteLine("3-я четверть");
    if (X<0 && Y>0) Console.WriteLine("4-я четверть");
}

// Запуск
int coordX = ReadData ("Введите координату X");
int coordY = ReadData ("Введите координату Y");
PrintQuiter (coordX, coordY);
