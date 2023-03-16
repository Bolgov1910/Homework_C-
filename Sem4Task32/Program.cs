// Задача №32 Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.



// метод заполнения - универсальный
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

// Делаем иневерсию
void InversArr (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
    }
}
int[] test = Gen1DArr (15,-9,9);
Print1DArr(test);    // Чтобы посмотреть заполнение:
InversArr (test);  // инверсия
Print1DArr(test);   // печать с обратным знаком
