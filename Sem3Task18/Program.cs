    // Напишите программу, которая по заданному номеру четверти, показывает 
    // диапазон возможных координат точек в этой четверти (x и y).

// Метод -  ввод данных - создание
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse (Console.ReadLine()?? "0");
}

// Метод -  вывода данных - создание
void PrintRez (int num)
{
    if (num==1) Console.WriteLine ("X>0,Y >0");
    if (num==2) Console.WriteLine ("X>0, Y<0");
    if (num==3) Console.WriteLine ("X<0, Y<0");
    if (num==4) Console.WriteLine ("X<0, Y>0");
}
// Запуск ввода
int num = ReadData ("Введите номер четверти");
// Запуск вывода c проверкой (есть только 4 четверти)
if (num >0 && num < 5) PrintRez (num);
else Console.WriteLine ("Это не номер четверти");

