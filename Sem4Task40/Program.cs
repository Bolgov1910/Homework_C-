// Задача №40 Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины

Console.WriteLine ("Введите 1-е число");
string? numb1 = Console.ReadLine();
int a = int.Parse(numb1);
Console.WriteLine ("Введите 2-е число");
string? numb2 = Console.ReadLine();
int b = int.Parse(numb2);
Console.WriteLine ("Введите 3-е число");
string? numb3 = Console.ReadLine();
int c = int.Parse(numb3);

// проверка
bool Test (int a, int b, int c)
{
    if (a<=b+c) return true;
    else return false;
}
bool Test3 (int a, int b, int c)
{
    if (Test (a,b,c) && Test (b,a,c) && Test (c, b, a)) return true;
    else return false;
}

Console.WriteLine("Можно построить треугольнк; " + Test3(a,b,c));
