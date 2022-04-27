// Домашнее задание 8. Кратность числа
Console.Write("Введите любое число: ");
int Number = int.Parse(Console.ReadLine());
int GivenNumber = 7;                                 // заданное число
if ((Number - Number/GivenNumber * GivenNumber) == 0)
{
    Console.Write("Ваше число кратно "+GivenNumber);
}
else    
    Console.Write("Ваше число не кратно "+GivenNumber);
