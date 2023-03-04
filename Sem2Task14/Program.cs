Console.WriteLine ("Введите число");
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

// операция как переменная
Console.WriteLine ("Введите число для использования bool");
int namA = int.Parse(Console.ReadLine()??"0");
// проверка сразу 2-х условий
bool oper = ((nam%7==0) && (nam%23==0));
Console.WriteLine("Некратно  " + oper);


// с тернарным оператором
Console.WriteLine ("Введите число для тернарного опенратора");
int namB = int.Parse(Console.ReadLine()??"0");
// проверка сразу 2-х условий
string rez = ((nam%7==0) && (nam%23==0))? "Кратно(терн.оп)" : "Некратно(терн.оп)";
Console.WriteLine(rez);
