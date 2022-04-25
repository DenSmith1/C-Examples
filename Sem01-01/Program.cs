Сonsole.Write("input digit A ");
int a = int.Parse(Console.ReadLine());
Console.Write("input digit B ");
int b = int.Parse(Console.ReadLine());
if (a != b)
{
    if (a > b)
    {
        Console.WriteLine("А > B");

    }
    else
    {
        Console.WriteLine("B > A");
    }
}
else
{
    Console.WriteLine("числа равны");
}
