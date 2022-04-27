// Домашнее задание 4. Показать четные числа
Console.Write("Введите любое число больше 1: ");
int number1 = int.Parse(Console.ReadLine());
int count = 1;
while (number1 < 2)
{
    Console.Write("Введите любое число больше 1: ");
    number1 = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ряд четных чисел: ");
while (count <= number1)
{
    if (count%2 == 0)
    {
        Console.Write (" "+count);
    }
    count++;
}
