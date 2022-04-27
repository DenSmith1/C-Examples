// Домашнее задание 5. Показать вторую цифру трехзначного числа
Console.Write("Введите любое трехзначное число: ");
int number1 = int.Parse(Console.ReadLine());
while (number1 < 100 || number1 > 999)
{
    Console.Write("ТРЕХЗНАЧНОЕ (THREE-DIGIT, DREISTELLIG, TROIS CHIFFRES): ");
    number1 = int.Parse(Console.ReadLine());
}
int SecondDigit = (number1 % 100) / 10;
Console.WriteLine("Вторая цифра: " + SecondDigit);
