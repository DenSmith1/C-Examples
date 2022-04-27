Console.Write("What is your name? ");
string name = Console.ReadLine();
Console.Write("How old are you? ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Your name is {0}. Your are {1} years old.",name,age);

Console.Write("What is your name? ");
string name = Console.ReadLine();
Console.Write("How old are you? ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Your name is {name}. Your are {age} years old.");
