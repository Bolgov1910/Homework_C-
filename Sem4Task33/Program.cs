// Задача №33 Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// метод запроса входящих данных
int ReadData (string line)
{
    Console.WriteLine(line);
    return int.Parse (Console.ReadLine()?? "0");
}


// метод заполнения - универсальный
int[] Gen1DArr(int len, int min, int max) // длина массива, минимум и максимум случайных чисел
{
    if (min>max) // это для того, чтобы поменять числа местами, если min оказалость больше max
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random(); // создается один генератор случайных чисел c именем rnd
    int[] arr = new int[len];
    for(int i=0; i<len; i++) arr[i] =  new Random().Next(min,max+1); // +1 - последнее число в интервал не входит
    return arr;
}


// метод: печать
void Print1DArr(int[] arr) 
{     
    Console.Write("[");                               //кавчка спереди 
    for (int i = 0; i < arr.Length - 1; i++)        // элементы массива (-1) - без последнего элемента 
    {         
        Console.Write($"{arr[i]}, ");                // на вывод
    }     
    Console.WriteLine($"{arr[arr.Length - 1]}]");    // вывод последнего элемента - это чтобы не было запятой в конце
}  
// Поиск элемента в массиве
int SearhElem (int[] arr, int elm)
{
    int res = -1;                  // чтобы результат не выдавл 1-й элемент при отсутствии числа, т.е, (-1) это отсутствие элемента
    for (int i=0; i<arr.Length; i++)        // элементы массива 
    {
        if (arr[i] == elm)
        res = i; break;       // break останавливает цикл, ближайший к нему, т.е. если число найдено - больше не ищем
    }
    return res;
}
int[] testAr = Gen1DArr (15,-9,9);
Print1DArr(testAr);    // Чтобы посмотреть заполнение:
int testElm = ReadData ("Введите число ");
int numRes = SearhElem (testAr, testElm);  // 
Console.WriteLine (numRes);
