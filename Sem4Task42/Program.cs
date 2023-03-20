// Задача №42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 45 -> 101101  3 -> 11   2 -> 10

// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}

// метод вывода результата
void Bin (string line)
{
    Console.WriteLine (line);
}
// перевод в двоичное
string numBin (int num)
{
    int i;
    string rez = string.Empty;
    while (num>0)
    {
        i = num%2;
        rez = i.ToString() + i;
    }
    return rez;
}
int num = ReadData("Число:");
//Bin (numBin(num));
string bin = numBin(num);
Console.WriteLine("Двоичное " + bin);

