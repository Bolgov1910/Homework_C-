//На входе цифра, обозначающую день недели. Проверка, является ли этот день выходным. 
Console.WriteLine ("Введите номер дня недели");
int num = int.Parse(Console.ReadLine()??"0");
// Вывод рабочих дней
if (num>0 && num<6)
    {
        Console.WriteLine ("Рабочий день");
    }
else
    {
// Вывод выходных дней
        if (num==6 || num==7)
            {
                Console.WriteLine ("Выходной день");
            }
// При вводе чисел, не обзначающимх дни недели
        else    
            {
            Console.WriteLine ("Введенное число не является днем недели");
            }
    }

//С использованием конструкции Dictionary
int numDey = 0;
// Создание словаря, сразу заполненного значениями
var DeysWeek = new Dictionary<int, string>()
{
    [1] = "Рабочий",
    [2] = "Рабочий",
    [3] = "Рабочий",
    [4] = "Рабочий",
    [5] = "Рабочий",
    [6] = "Выходной",
    [7] = "Выходной"
};
if (num>0 && num<8)
    {
        numDey = num;
        Console.WriteLine($"В словаре: {DeysWeek[numDey]}"); 
    }
else 
    {
        Console.WriteLine ("Ключ отсутствует в словаре");        
    }

