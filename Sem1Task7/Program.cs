// Последняя цифра 3-х значного числ
Console.WriteLine("Вести 3-х значное число:");
string? numJob = Console.ReadLine();
int num = int.Parse(numJob);
if (num!=null)
{
    int result = num % 10;
    Console.WriteLine("Последнее число:" + result);
}