// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// метод заполнения массива
int[] Gen1DArr(int len, int min, int max) // длина массива, минимум и максимум случайных чисел
{
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


// метод подсчета количества четных чисел
int EvenNumbers (int[] arr)  // 
{
    int evenNum =0;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            evenNum = evenNum+1;
        }
    }
    return (evenNum);
}

// создем массив
int[] testAr = Gen1DArr (15,100,1000);
Print1DArr(testAr);    // Чтобы посмотреть заполнение:
int res = EvenNumbers (testAr);    // Запуск метода подсчета количества четных чисел
Console.WriteLine("Четных чисел: " + res);  // Печать результата
