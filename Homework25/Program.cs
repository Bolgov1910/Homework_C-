// №25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 

// метод запроса входящих данных
int ReadData (string line)
{
    Console.WriteLine(line);
    return int.Parse (Console.ReadLine()?? "0");
}
// метод вывода результата
void PrintRez (string line)
{
    Console.WriteLine (line);
}
// метод расчета
double Degr (int x, int y)
{
    double rez = Math.Pow(x, y);
    return rez;
}

int x = ReadData ("Введите первое число:");
int y = ReadData ("Введите второе число:");
double numFact = Degr (x,y);
PrintRez ($" {x} в степени {y} = {numFact}");
// !! - ни одна математическая функция не работает с "int"