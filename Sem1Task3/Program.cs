// Задача 03: Вывод дня недели  
//  
Console.WriteLine ("Введите номер дня недели");
string? NumDay = Console.ReadLine();
string[] DayWeek = {"Пон", "Вт", "Ср","Чт","Птн","Сбб","Вскр"};
int Day = int.Parse(NumDay);
if (NumDay!=null)
{
    if (Day<8 && Day>0)
    Console.WriteLine (DayWeek[Day - 1]);
    else
    {
        Console.WriteLine ("Некорректный номер дня недели");
    }

}