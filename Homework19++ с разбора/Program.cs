
// Создаем словарь c четырехзначными числами



// DictionaryFill - это метод, который создает словарь
Dictionary<int, int> DictionaryFill();
{
Dictionary<int, int> Palindr = new Dictionary <int, int>();
for (int i=10; i < 100; i++)
// Берем ключ
int Key = 1;
{
    string part = string.Empty;
    part = part + i + i%10 + i/10;
    int key = Int32.Parse (part);
    //Console.WriteLine(key); - вывод ключей 
    Palindr.Add(key, "Палиндром");
}