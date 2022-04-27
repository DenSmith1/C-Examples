// Домашнее задание 9. Найти 3ю цифру числа
Console.Write("Введите любое число: ");
int Number = int.Parse(Console.ReadLine());
if (Number < 99)
{
    Console.Write("Нет третьей цифры");
}
int BitDepth = 2;                               // начальная разрядность числа
int NumberDepth = Number;
while (NumberDepth / 10 > 9)                    // определяем разрядность числа
{
    NumberDepth = NumberDepth / 10;
    BitDepth++;
}
// думаю проще сделать через степень (Pow), но раз мы ее не проходили, то вот такое решение:
int count = 0;
int Depth = 1;
while (count < BitDepth - 2)
{
    Depth = Depth * 10;                         // глубина разрядности для расчета 3 цифры
    count++;
}
Console.Write("Третья цифра числа: ");
Console.WriteLine(Number % Depth / (Depth / 10));
