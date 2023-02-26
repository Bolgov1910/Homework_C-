// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее  

Console.WriteLine ("Введите первое число");
string? Num1 = Console.ReadLine();
Console.WriteLine ("Введите второе число");
string? Num2 = Console.ReadLine();
if (Num1 != null && Num1 != null)
{
    int number1 = int.Parse(Num1);
    int number2 = int.Parse(Num2);
    if (number1 > number2)
    {
        Console.WriteLine ("Первое число большее" + "(" + number1 + ")" + "\t" + "Второе число меньшее" + "(" + number2 + ")");
    }
    else
    {
        Console.WriteLine ("Второе число большее" + "(" + number2 + ")" + "\t" + "Первое число меньшее" + "(" + number1 + ")");
    }
}