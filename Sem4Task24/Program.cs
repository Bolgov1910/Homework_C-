// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.  

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

// Метод суммирования
int Sum (int numA)
{
    int sum = 0;
    for (int i = 0; i <= numA; i++)
    {
        sum+=i;  // это то же, что sum=sum+i - увеличение sum на i 
    }
    return sum;
}

// Ввод А через метод
int numA = ReadData ("Введите число А ");
DateTime d1 = DateTime.Now; // Для сравнения времени работы способов вводим переменную времени
// Запуск расчета
int rez = Sum (numA);
Console.WriteLine (DateTime.Now - d1); // Выводим разницу времени с кона операции до начала
// Вывод результата
PrintRez ("Результат методом 1 (простой) = " + rez);

// 2-й способ - прием Гаусса 
int SumGauss (int numA)
{
    return (1+ (1+numA)*numA)/2;
}
DateTime d2 = DateTime.Now; // вводим переменную времени для сособа Гаусса
int rez1 = SumGauss (numA);
Console.WriteLine (DateTime.Now - d2); // Выводим разницу времени с кона операции до начала
PrintRez ("Результат способом Гаусса = " + rez1);
