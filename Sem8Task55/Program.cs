// Задача №55  Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.
// ТРАНСПОНИРОВАНЕ


// Здесь ОШИБКА
//static void Main(string[] args)
//{
    int[,] someArray = new int[10, 10];
    int rows = someArray.GetUpperBound(0) + 1;
    int columns = someArray.GetUpperBound(1) + 1;
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            someArray[i, j] = rand.Next(-100, 100);
            Console.Write("{0,4}", someArray[i, j]);
        }
        Console.WriteLine();
    }
    for (int i = 0; i < columns; i++)
    {
        int tmp = someArray[1,  i];
        someArray[1, i] = someArray[3, i];
        someArray[3, i] = tmp;
 
    }
    for (int i = 0; i < rows; i++)
    {
        int tmp = someArray[i, 2];
        someArray[i, 2] = someArray[i, columns - 1];
        someArray[i, columns - 1] = tmp;
    }
    Console.WriteLine("Transformed array: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write("{0,4}", someArray[i, j]);
        }
        Console.WriteLine();
    }
//}