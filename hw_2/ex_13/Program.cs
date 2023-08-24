int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void CheckMethod(int num, int num2)
{
    if (num < 100)
        Console.WriteLine("Третьей цифры нет");
    else 
        Console.WriteLine($"Третьим числом является число {num2}");
}

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
        return num % 10;
}

// void PrintThird(int num)
// {
//     Console.WriteLine($"Третьим числом является число {num}");
// }

int number = InputNum("Введите число: ");
int thirdDigit = ThirdDigit(number);
CheckMethod(number, thirdDigit);
