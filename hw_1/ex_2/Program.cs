Console.Write ("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write ("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2) Console.WriteLine($"Большее число {number1}, а меньшее число {number2}");
else Console.WriteLine($"Большее число {number2}, а меньшее число {number1}");