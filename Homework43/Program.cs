// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
 // * Найдите площадь треугольника образованного пересечением 3 прямых

// ввод
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
 
 // расчет
int x = -(b1 - b2) / (k1 - k2);
int y = k1 * x + b1;
 
 // вывод результата
Console.WriteLine($"Пересечение в точке: ({x};{y})");