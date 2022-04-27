// Домашнее задание 7. Удалить вторую цифру трехзначного числа
Console.Write("Введите любое трехзначное число: ");
int number1 = int.Parse(Console.ReadLine());
while (number1 < 100 || number1 > 999)
{
    Console.Write("ТРЕХЗНАЧНОЕ (THREE-DIGIT, DREISTELLIG, TROIS CHIFFRES): ");
    number1 = int.Parse(Console.ReadLine());
}
int FirstDigit = number1 / 100;
int ThirdDigit = number1 % 10;
int NewNumber = FirstDigit*10 + ThirdDigit;
Console.WriteLine (NewNumber);
