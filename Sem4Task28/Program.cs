// Задача №28 Напишите программу, которая принимает на вход число N и выдаёт 
//произведение чисел от 1 до N.

using System.Numerics; // using - подключение внешних данных.BigInteger - нет в стандартной загрузке

// метод запроса входящих данных
int ReadData (string line)
{
    Console.WriteLine(line);
    return int.Parse (Console.ReadLine()?? "0");
}
// метод вывода результата
void PrintRez (string line)
{
    Console.WriteLine (line);
}

BigInteger FactorCalk (int num)   // BigInteger - произвольно большое целое число со знаком.
{
    BigInteger rez=1;
    for(int i=1; i <= num; i++)
    rez = rez * i;
    return rez;
}

int num = ReadData ("Введите число");
BigInteger numFact = FactorCalk(num);
PrintRez ($"Факториал числа {num} = {numFact}");
