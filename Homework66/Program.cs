// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine ("Введите число M");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число N");
int Num2 = Convert.ToInt32(Console.ReadLine());

// Метод расчета суммы
int SumNum(int n, int m)
{
  if (n == m) return n;
  else return SumNum(n + 1, m) + n; // рекурсия
}

Console.WriteLine($"Cумма натуральных элементов в промежутке от {Num1} до {Num2} равна, {SumNum(Num1, Num2)}");

