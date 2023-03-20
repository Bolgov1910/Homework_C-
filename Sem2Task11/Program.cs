// Удаление второй цифры случайного трехзначного числа
// генерируем случайное число
int num = new Random().Next(100,1000);
Console.WriteLine(num);
// Найдем последнее число
int lastNum = num%10;
// Найдем первое число
int firstNum = num/100;
// Используем ту же переменную для вывода результата

//num = firstNum*10 + lastNum;
//Console.WriteLine(num);

// Или совсем просто

