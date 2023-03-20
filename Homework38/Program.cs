// №38 Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// метод заполнения массива
//double[] Gen1DArr(double n1, double n2,double n3,double n4,double n5) // 5 элементов в массиве
//{
//    double[] arr = new double [5];
//    Console.WriteLine(n1);
//    return n1;
//}
// Console.WriteLine ("Введите длину массива:");
// string? length = Console.ReadLine();
// int len = int.Parse(length);
//int ReadData (string line)
//{
//    for 
//    Console.WriteLine(line);
//    return int.Parse (Console.ReadLine()?? "0");
//}
//double testAr (int len)
//{
//    for (int i = 0; i < len; i++)
//Console.WriteLine ("Введите 1-е число");
// string? numb1 = Console.ReadLine();
// double num1 = double.Parse(numb1);
// }
Console.WriteLine ("Введите 1-е число");
string? numb1 = Console.ReadLine();
double num1 = double.Parse(numb1);
            //double n1 = number1*1;
            //double? n1 = double.ToDouble (string? Num1);
            //string a = textBox1.Text;
            //a = a.Replace('.', ',');
            //double a1 = Double.Parse(a.ToString());
Console.WriteLine ("Введите 2-е число");
string? numb2 = Console.ReadLine();
double num2 = double.Parse(numb2);

Console.WriteLine ("Введите 3-е число");
string? numb3 = Console.ReadLine();
double num3 = double.Parse(numb3);

Console.WriteLine ("Введите 4-е число");
string? numb4 = Console.ReadLine();
double num4 = double.Parse(numb4);

Console.WriteLine ("Введите 5-е число");
string? numb5 = Console.ReadLine();
double num5 = double.Parse(numb5);

//double? n1 = Console.ReadLine();

// Объявляется массив из введенных чисел
double[] testAr = new double[] {num1, num2, num3, num4, num5};

// метод: печать массива
void Print1DArr(double[] arr) 
{     
    Console.Write("[");                               //кавчка спереди 
    for (int i = 0; i < arr.Length - 1; i++)        // элементы массива (-1) - без последнего элемента 
    {         
        Console.Write($"{arr[i]}, ");                // на вывод
    }     
    Console.WriteLine($"{arr[arr.Length - 1]}]");    // вывод последнего элемента - это чтобы не было запятой в конце
}

//double[] testAr = Gen1DArr (5,0,10);
//double testAr = Gen1DArr (num1,num2,num3,num4,num5);

Print1DArr(testAr);    // Чтобы посмотреть заполнение:


// Метод расчетв и вывода результата
//double SelectMin(double[] array)
//{
    //double minPosition = 0;
    double minPosition = 0;
    double maxPosition = 0;
//minPosition = testAr[i];
//maxPosition = testAr[i];

for (int i = 0; i < testAr.Length-1; i++)  // 
    {
        
        // for (int j = i+1; j < array.Length; j++)
        //{
            if (testAr[i] < minPosition); minPosition = testAr[i];
            if (testAr[i] > maxPosition); maxPosition = testAr[i];        //{
            //double min = minPosition;
            //double max = maxPosition;
            
            //minPosition = j;
            //}
        //}    
        //double temporary = array[i];
        //array[i] = array [minPosition];
        //array[minPosition] = temporary;
        // return minPosition;
    testAr[0] = minPosition;
    testAr[testAr.Length-1] = maxPosition;
    }
double res = testAr[testAr.Length-1]-testAr[0];
Console.WriteLine("Разница между максимальным и минимальным = "+  res);
//    return minPosition;
//}    
    
// double SelectMax(double[] array)    
//{    //double maxPosition =0;
    //for (int i = 0; i < testAr.Length-1; i++)  // 
//    {
//        double maxPosition = testAr[i];
        // for (int j = i+1; j < array.Length; j++)
        //{
//            if (testAr[i] > maxPosition); maxPosition = testAr[i];
            //{
            //minPosition = j;
            //}
        //}    
        //double temporary = array[i];
        //array[i] = array [minPosition];
        //array[minPosition] = temporary;
    //return maxPosition;
//    }
//    return maxPosition;
//}
// Расчет и вывод 
//selectionSort (testAr);

// double res = maxPosition - miminPositionn;
//  Console.WriteLine("Разница между максимальным и минимальным = ",  res);