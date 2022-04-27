// Домашнее задание 6. Сравнение чисел в диапазоне
Console.Write("Введите число в интервале [10:99]: ");
int number1 = int.Parse(Console.ReadLine());
while (number1 < 10 || number1 > 99)
{
    Console.Write("Попробуйте еще раз. Интервал 10 - 99: ");
    number1 = int.Parse(Console.ReadLine());
}
int FirstDigit = number1 / 10;
int SecondDigit = number1 % 10;
if (FirstDigit >= SecondDigit)
{
    Console.WriteLine(FirstDigit);
}
else
    Console.WriteLine(SecondDigit);
