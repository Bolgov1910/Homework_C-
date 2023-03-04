// Наибольшая цифра случайного двухзначного числа

// Так же, как в Sem2Task9: Задается медод numSintez - генерация случайных чисел
System.Random numSintez = new System.Random();
// Объявляется массив с именем digits и типом данных char (символы)
// Он заполняется случайными числами от 10 до 99. Числа преобразуются в строку символов
// затем в массив символов
char[]digits=numSintez.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
// Символ № 1 (индекс - 0) превращаем в число и кладем в переменную firstNam
int firstNam = ((int)digits[0]-48);
// Символ № 2 (индекс - 1) превращаем в число и кладем в переменную secNam
int secNam = ((int)digits[1]-48);
// Тернарный оператор Условный (тернарный) оператор - оператор, принимающий три операнда: 
// условие?выражение при true:выражение при false
int resultNam = (firstNam>secNam)?resultNam= firstNam: resultNam= secNam;
Console.WriteLine("Болшее число: " + resultNam);