// №29  Напишите программу, которая задаёт массив из 8 элементов и выводит 
//их на экран. * Ввести с клавиатуры длину массива и диапазон значений элементов
// доработано с задачи 30 (семинар 4)

// метод - ввод данных
int ReadData (string line)
{
    Console.WriteLine(line);
    return int.Parse (Console.ReadLine()?? "0");
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

// метод выполнения - универсальный
int[] Gen1DArr(int len, int min, int max) // длина массива, минимум и максимум случайных чисел
{
    int[] arr = new int[len];
    for(int i=0; i<len; i++) arr[i] =  new Random().Next(min,max+1); // +1 - последнее число в интервал не входит
    return arr;
}
int lenArr = ReadData ("Введите требуемую длину массива");
int minArr = ReadData ("Введите начальныое значение интервала случайных данных");
int maxArr = ReadData ("Введите конечное значение интервала случайных данных");
if (maxArr > minArr)
{
    Print1DArr(Gen1DArr(lenArr,minArr,maxArr));
}
else
{
    Console.WriteLine ("Конечное значение введено некорректно");
}
