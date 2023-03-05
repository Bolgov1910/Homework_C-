﻿Console.WriteLine ("Введите число");

// вводим переменную. Условие - "3-х значное число"
int num = int.Parse(Console.ReadLine()??"0");
// Прверка условия: меньше, чем 3-х значное
if (num < 100)
    {
        Console.WriteLine ("Число не трехзначное.");
    }
    else 
// Прверка условия: больше, чем 3-х значное
        if (num > 999)
            {
                Console.WriteLine ("Число не трехзначное.");
            }   
// Получаем и выводим результат при выполнении условия
else
{
// 1 способ - через расчет
    int res = (num/10)%10;
    Console.WriteLine ($"Вторая цифра числа Способ 1: {res}");
// 2 способ - через заполнение строки - массива и вывод второго значения массива
// "-48" - перевод символа в число
    char[]digit=num.ToString().ToCharArray();
    int res2 = ((int)digit[1]-48);
    Console.WriteLine ("Вторая цифра числа Способ 2: "+res2);
}


