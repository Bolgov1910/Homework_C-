// №19 На входе пятизначное число на выходе:является ли оно палиндромом.
// *Вариант через СЛОВАРЬ четырехзначных палиндромов

// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}
// Метод формирования результата – создание. тип bool: "true" или "false" 
// только для пятизначного числа: "истина" если равны 
// (первое и последнее) и (второе с начала и второе с конца)
bool PalTest (int num)
{
   bool rez = false;
   if ((num/10000==num%10) && (num/1000%10==num/10%10)) 
   {
   rez = true;
   }
   return rez;
}
// Метод -  вывода данных - создание
void PrintData (string msg, bool pal)
{
    Console.WriteLine (msg + pal);
}
// Запуск ввода
int fiveDigNumber = ReadData ("Введите пятизначное число");
// Проверка  и запуск формирования результата
if ((fiveDigNumber<10000) || (fiveDigNumber>99999))
    {
    Console.WriteLine ("Число не пятизначное или отрицательное");
    }
else 
    {
    bool PalRez = PalTest (fiveDigNumber);
    PrintData ("Палиндром - ", PalRez);
    }
