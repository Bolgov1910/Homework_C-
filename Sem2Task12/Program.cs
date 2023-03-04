// второе число кратно первому, или выводится остаток

// вводим 1 число с консоли c проверкой: если введено некорректное значение, выдается 0.
int nam1 = int.Parse(Console.ReadLine()??"0");
// вводим 2 число с консоли другим методом – он медленнее (внутри больше проверок)
// int nam2 = Convert.Toint()(Console.ReadLine());
// Не получилось - " error CS0117: "Convert" не содержит определение для "Toint"."
// Если ....ToInt32.... - воообще вылетает
int nam2 = int.Parse(Console.ReadLine()??"0");
int rem = nam2% nam1;
if (rem ==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Некратно. Остаток:  " + rem);
}
