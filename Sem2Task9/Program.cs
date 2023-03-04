// Наибольшая цифра случайного двухзначного числа

// Обращение: Ядро SDK, Виртуальная машина RLR, Генератор случайных чисел
// Задается медод numSintez - генерация случайных чисел
// Генерируеся число 10-99 и показывается наибольшая цифра числа
System.Random numSintez = new System.Random();
// вводим переменную и заполняем переменной с помощью созданного метода
int rndNum = numSintez.Next (10,100);
Console.WriteLine(rndNum);
int firstNam = rndNum/10;
int secNam = rndNum%10;
if (firstNam> secNam)
{
    Console.WriteLine("Болшее число: " + firstNam);
}
else
{
    Console.WriteLine("Болшее число: " + secNam);
}




