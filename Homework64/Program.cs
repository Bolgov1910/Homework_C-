// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"


Console.WriteLine ("Введите число N:");
string? Num = Console.ReadLine();
int number = int.Parse(Num);

// Метод вывода чисет
int NaturalNumber(int n, int m)  // m - начало диапазона чисел, ряд будет от m до n
{
    if (n == m)      // до тех пор, пока m не сравняется с n
    {
        return n;
    }
    else Console.Write($"{NaturalNumber(n, m + 1)}, "); // печать чисел: рекурсия
  return m;
}

if (number < 1)        // проверка. Число д.б. > 0, иначе рекурсия не остановится
{
  Console.WriteLine("Ввдите число больше 0!");
  return;
}
Console.WriteLine(NaturalNumber(number, 1)); // 

