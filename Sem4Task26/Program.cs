// Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.

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


int num = ReadData ("Введите число");
int rez = num.ToSrting().Length;              // не работает ни в какую: ""int" не содержит определения "ToSrting", и не удалось найти доступный метод расширения "ToSrting", принимающий тип "int" в качестве первого аргумента"
double rez1 = Math.Floor(Math.Log10(num)+1); // не работает с int, а double выдает дроби Floor -округление до целого
PrintRez ("Количество цифр в числе строкой-  " + rez);
PrintRez ("Количество цифр в числе логарифмом-  " + rez1);
