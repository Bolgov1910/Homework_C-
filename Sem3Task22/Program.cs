// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу квадратов чисел от 1 до N.

// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}

// Метод формирования результата – создание. Строка для накопления результатов
string LineBuilder (int num, int pow)
{
   string rez = string.Empty;
   for (int i=1; i <= num; i++)
   { 
   rez = rez + Math.Pow(i, pow) + ",  ";
   }
   return rez;
}

// Метод -  вывода данных - создание
void PrintData (string data, string data1)
{
    Console.WriteLine ("Число:   {0} \nКвадрат: {1}", data, data1);
}

// Запуск ввода
int num = ReadData ("Введите число N");
int pow = ReadData ("Введите степень");
// Формирование строки с исходными данными
string numN = string.Empty;
int j=1;
for (int i=j; j <= num; j++)
{ 
    numN = numN + j + ",  ";
}
// Запуск формирования результата
string rezPov = LineBuilder (num, pow);

// Запуск вывода
//PrintData (numN);
PrintData (numN, rezPov);
