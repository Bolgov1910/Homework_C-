//Задача №31 Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.



// меnод вывода данных - результат
void PrinData (string res, int value)
{
    Console.WriteLine (res + value);
}

// метод заполнения - универсальный
int[] Gen1DArr(int len, int min, int max) // длина массива, минимум и максимум случайных чисел
{
    if (min>max)  // числа переставляем, если введены неправильно
    {
        int buff = min;
        min = max;
        max = buff; 
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for(int i=0; i<len; i++) 
    {
        arr[i] =  rnd.Next(min,max+1); // +1 - последнее число в интервал не входит
    }
    return arr;
}

// складываем положительные (позитив) и отрицательные (негатив)
(int posit, int negot) NegPosSumm(int[] arr)  // метод сразу с двуми результатами
{
    int positSum =0;
    int negotSum =0;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            positSum = positSum + arr[i];
        }
        else
        {
            negotSum = negotSum + arr[i];
        }
    }

    return (positSum, negotSum);
}

// Метод печати -  1 одномерный массив
void Print1DArr (int[] arr) 
{     
   Console.Write("[");                               //кавчка спереди 
    for (int i = 0; i < arr.Length - 1; i++)        // элементы массива (-1) - без последнего элемента 
    {         
        Console.Write($"{arr[i]}, ");                // на вывод
    }     
    Console.WriteLine($"{arr[arr.Length - 1]}]");    // вывод последнего элемента - это чтобы не было запятой в конце
}  

int[] testArr = Gen1DArr (15, -9, 9);                      // генерируем массив 
Print1DArr (testArr);                                   // печатаем массив
// создаем пару переменных под одним именем и заполняем их методом (нн тоже выдает пару результатов)
(int posit, int negot) results = NegPosSumm(testArr);  
PrinData ("Сумма положительных:", results.posit);   // печать переменной: сначала общее имя, потом навание
PrinData ("Сумма ортрицательных:", results.negot);  // печать переменной: сначала общее имя, потом навание
