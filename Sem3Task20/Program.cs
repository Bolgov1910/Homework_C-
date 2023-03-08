// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}
// Метод -  расчета – создание - для дробных чисел
double CalcDist2D (int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2-x1)* (x2-x1) + (y2-y1)* (y2-y1));
}

// Метод -  вывода данных - создание
void PrintData (string msg, double data)
{
    Console.WriteLine (msg + data);
}

// Запуск ввода
int x1 = ReadData ("Введите координату X точки А");
int y1 = ReadData ("Введите координату Y точки А");
int x2 = ReadData ("Введите координату X точки B");
int y2 = ReadData ("Введите координату Y точки B");
// Запуск расчета, считаем dist
double dist = CalcDist2D (x1, x2, y1, y2);
// Запуск вывода
PrintData ("Расстояние  между точками  ", dist);