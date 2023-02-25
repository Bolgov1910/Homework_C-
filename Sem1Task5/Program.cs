// Все целые числа от –n до n
Console.WriteLine("Вести число:");
string? num = Console.ReadLine();
if (num!=null)
{
    int namStart = int.Parse(num);
    int namJob = namStart*(-1);
    string outLine = string.Empty;
    while (namJob<namStart)
    {
        outLine = outLine + namJob + ",   ";
        namJob++; // namJob = namJob + 1
    }
    outLine = outLine + namStart;
    Console.WriteLine(outLine);
}