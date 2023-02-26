// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.  
Console.WriteLine ("Введите 1-е число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2-е число");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 3-е число");
int Num3 = Convert.ToInt32(Console.ReadLine());
int maxNum = 0;
if (Num1 > Num2)
{
    maxNum = Num1;
}
else
{
    maxNum = Num2;
}
if (Num3 > maxNum)
{
    maxNum = Num3;
}
Console.WriteLine ("Максимальное число = " + maxNum);
