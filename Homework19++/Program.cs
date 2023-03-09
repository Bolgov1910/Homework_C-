//Удалось заполнить Dictionary через цикл (проверено через вывод списка ключей
// и прямое обращение к словарю)
// Удалось сделать проверку на пятизначность



// Создаем словарь и цикл для его заполнения
Dictionary<int, string> Palindr = new Dictionary <int, string>();
for (int i=10; i < 100; i++)
{
    string part = string.Empty;
    part = part + i + i%10 + i/10;
    int key = Int32.Parse (part);
    //Console.WriteLine(key); - вывод ключей 
    Palindr.Add(key, "Палиндром");
}

Console.WriteLine ("Введите число пятизначное число");
int num = int.Parse(Console.ReadLine()??"0");
double lg = Math.Log10(Math.Abs(num)) + 1;
if (lg < 5 || lg >= 6)
    {
        Console.WriteLine("Число не пятизначное"); 
    }
// else
//{
//    char[]digits = num;
//}

string sam = Palindr[5555];
Console.WriteLine(lg);
Console.WriteLine(sam); 
//Console.WriteLine(numTest);