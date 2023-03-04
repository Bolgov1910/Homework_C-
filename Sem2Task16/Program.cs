// Одно число - квадрат другого

// вводим 1 и 2 числа с консоли c проверкой: если введено некорректное значение, выдается 0.
Console.WriteLine ("Введите 1- е число");
int nam1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ("Введите 2- е число");
int nam2 = int.Parse(Console.ReadLine()??"0");

// вводим метод void (void – метод, который ничего не возвращает, поэтому return не используется)
void SquareCheck (int numA, int numB)
{
    if (numB == numA* numA || numA == numB * numB)
    {
        if (numA == numB * numB)
        {   
        Console.WriteLine("Первое число – квадрат второго");
        }
        else
            {
                if (numB == numA* numA)
                {
                    Console.WriteLine("Второе число – квадрат первого");
                }
            }
    }
    else
    {
        Console.WriteLine("Числа не квадраты друг друга");
    }
}
SquareCheck (nam1, nam2);
