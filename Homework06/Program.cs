// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).  
Console.WriteLine ("Введите число:");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num % 2 == 0)
{
   Console.WriteLine ("Это четное число");
}
else
{
   Console.WriteLine ("Это число нечетное");
}