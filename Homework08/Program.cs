// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
string even = string.Empty;
if (num > 0)
{
    while (count <= num)
    {
    if (count%2 == 0)
    even = even + count + "\t";
    count++;
    }
}
else
{
   Console.WriteLine ("Значение вне промежутка 1 - N");
}
Console.WriteLine (even);
