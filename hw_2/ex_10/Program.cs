int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FindSecond (int num)
{    
     return num / 10 % 10;
}

void PrintSecond (int num)
{
    Console.WriteLine($"Вторым числом в числе является число {num}");
}

int number = InputNum ("Введите трехзначное число: ");
int secondNumber = FindSecond(number);
PrintSecond(secondNumber);

