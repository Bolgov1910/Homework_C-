 // №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
 // больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за 
// нажатиями и выдает сколько чисел больше 0 было введено.

// using Systems.Text.RegularExpressions; // запрос к серввисам

//int tabs = ReadData ("Введите количество цифр");
//    string inputline = ReadData ("Введите числа");
//    Console.Writeline(inputline);
//    FindNumberString (inputline, tabs);

    // метод - считывание с консоли
//    int ReadData (string num)
//    {
//        Console.Writeline(num);
//        return int.Parse(Console.ReadLine()?? "0");
//    }



 // метод заполнения массива
//int[] Gen1DArr(int len) //int min, int max) // длина массива, минимум и максимум случайных чисел
//{
//    int[] arr = new int[len];
//    for(int i=0; i<len; i++) 
//    Console.WriteLine("Введите число:");
//    return int.Parse (Console.ReadLine()?? "0"); // +1 - последнее число в интервал не входит
//    //return arr;
//}

//int[] lenArr = Gen1DArr ("Введите требуемую длину массива");
//int minArr = ReadData ("Введите начальныое значение интервала случайных данных");
//int maxArr = ReadData ("Введите конечное значение интервала случайных данных");

//
Console.Write("Введите числачерез пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
// подсчет положительных 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 Console.WriteLine($"Положительных чисел: {count}");
 