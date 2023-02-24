// Задача 01: Првоерка - являетня ли первое число квадратом второго
//  
Console.WriteLine ("Введите первое число");
string inputNum1 = Console.ReadLine();
Console.WriteLine ("Введите второе число");
string inputNum2 = Console.ReadLine();
if (inputNum1 != null && inputNum1 != null)
{
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    if (number1 == (int)Math.Pow(number2,2))
    {
        Console.WriteLine ("Да - Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine ("Нет - Первое число не является квадратом второго");
    }

}