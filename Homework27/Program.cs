// №27 Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе. 


// метод запроса входящих данных
int ReadData (string line)
{
    Console.WriteLine(line);
    return int.Parse (Console.ReadLine()?? "0");
}
// медод вывода результата
void PrintRez (string line)
{
    Console.WriteLine (line);
}
// метод расчета
int SumNum (int num)
{
    int rez = 0;
    while ( Math.Abs(num) > 0)
    {
        rez = rez + num%10;
        num = num/10;
    }
    return rez;
}

//int ReadDataStr (string line);
DateTime d1 = DateTime.Now; // Для сравнения времени работы способов вводим переменную времени
int n = ReadData ("Введите число");
int rez = SumNum (n);
PrintRez ($"Сумма цифр числа {n} = {rez}");
Console.WriteLine ($"Время выполнения: {DateTime.Now - d1}"); // Выводим разницу времени с кона операции до начала

// rez1 = n.ToSrting().Length;     // не работает ни в какую: ""int" не содержит определения "ToSrting", и не удалось найти доступный метод расширения "ToSrting", принимающий тип "int" в качестве первого аргумента"
// другие пробовал разные форматы для rez1 и n