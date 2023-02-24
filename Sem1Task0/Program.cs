// Задача 0 - Квадрат числа
Console.WriteLine ("Введите число");
string? inputNum = Console.ReadLine(); //"?" - не проверяем на Null
// Проверяем, чтобы данные были не пустые (Null)
if (inputNum !=null)
{
    //int number = int.Parse(inputNum);
    //int outNum = (int)Math.Pow(number,2);
    //Console.WriteLine ("Квадрат числа:"+outNum);
    Console.WriteLine ("Квадрат числа: "+Math.Pow(int.Parse(inputNum),2));
}