Console.WriteLine ("Введите первое число");
int nam = int.Parse(Console.ReadLine()??"0");
// проверка сразу 2-х условий
if ((nam%7==0) && (nam%23==0)) 
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Некратно 7 и 23");
}

Console.WriteLine ("Введите первое число для использования bool");
int namA = int.Parse(Console.ReadLine()??"0");
// проверка сразу 2-х условий
bool oper = ((nam%7==0) && (nam%23==0));
Console.WriteLine("Некратно  " + oper);
