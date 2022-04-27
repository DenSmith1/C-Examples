// Домашнее задание 1
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number2*number2 == number1)
    Console.Write(number1+" Является квадратом числа "+number2);
else
    Console.Write(number1+" НЕ является квадратом числа "+number2);