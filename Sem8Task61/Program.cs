// Задача №61 Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного 
// треугольника

// метод запроса входящих данных - для ввода числа n
int ReadData (string line)
{
    Console.WriteLine(line);
    int num = int.Parse (Console.ReadLine()?? "0");
    return num;
}

//     n! / k! * (n-k)!  ??? n! / k! * (n!-k!)
//         1
//        1 1
//       1 2 1

// метод расчета факториала
long Factorial (int n)
{
    long rez = 1;
    for (int i=1; i<=n; i++)
    {
        rez = rez * i;
    }
    return rez;
}

// печать результата
void PrintPascTr (int nRow)
{
    for (int i=0; i<nRow; i++)
    {
        for (int k=0; k<=nRow-i; k++)  // печатаем пробелы перед элементами в строке- для первой строки крутится n раз, далее меньне на 1
        {
            Console.Write(" ");
        }
        for (int j=0; j<=i; j++)  // счимтем количество элементов в строке
        {
            Console.Write(" ");
            Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j))); // hfcxtn gk
        }
    Console.WriteLine();
    }
}

int countRow = ReadData ("Введите n (кол-во строк треугольника Паскаля)");
PrintPascTr (countRow);
