// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// метод заполнения массива
int[] Gen1DArr(int len, int min, int max) // длина массива, минимум и максимум случайных чисел
{
    int[] arr = new int[len];
    for(int i=0; i<len; i++) arr[i] =  new Random().Next(min,max+1); // +1 - последнее число в интервал не входит
    return arr;
}
// метод: печать массива
void Print1DArr(int[] arr) 
{     
    Console.Write("[");                               //кавчка спереди 
    for (int i = 0; i < arr.Length - 1; i++)        // элементы массива (-1) - без последнего элемента 
    {         
        Console.Write($"{arr[i]}, ");                // на вывод
    }     
    Console.WriteLine($"{arr[arr.Length - 1]}]");    // вывод последнего элемента - это чтобы не было запятой в конце
}  


// метод подсчета суммирование чисел на нечетных позициях
int NoEvenPosNumSum (int[] arr)
{
    int Sum =0;
    for (int i=0; i < arr.Length; i++)   // нечетнве позиции - индексы 0, 2, 4.... 
    {
        if (i%2==0)
        {
            Sum = Sum + arr[i];
        }
    }
    return (Sum);
}

// создем массив
int[] testAr = Gen1DArr (6,0,9);
Print1DArr(testAr);    // Чтобы посмотреть заполнение:
int res = NoEvenPosNumSum (testAr);    // Запуск подсчета суммирование чисел на нечетных позициях
Console.WriteLine("Сумма чисел на нечетных позициях: " + res);  // Печать результата
