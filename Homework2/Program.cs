// Домашнее задание 2. Дни недели
Console.Write("Введите номер дня недели (1-7): ");
int number1 = int.Parse(Console.ReadLine());
while (number1 > 7 || number1 < 1)
{
    Console.Write("Вы ввели неверный номер недели. Повторите попытку: ");
    number1 = int.Parse(Console.ReadLine());
}
if (number1 == 1)
{
    Console.Write("ПОНЕДЕЛЬНИК");
}
if (number1 == 2)
{
    Console.Write("ВТОРНИК");
}
if (number1 == 3)
{
    Console.Write("СРЕДА");
}
if (number1 == 4)
{
    Console.Write("ЧЕТВЕРГ");
}
if (number1 == 5)
{
    Console.Write("ПЯТНИЦА");
}
if (number1 == 6)
{
    Console.Write("СУББОТА");
}
if (number1 == 7)
{
    Console.Write("ВОСКРЕСЕНЬЕ");
}