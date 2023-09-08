int ImputNum (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SumOfDigit (int num)
{
    int sum = 0;
    while (num < 0)
    {
        sum = num % 10;
        num = num - 1;
    }
    return count;
}



// int dig = ImputNum("Введите число: ");
// int result = SumOfDigit(dig);
// Console.WriteLine($"Сумма цифр числа {dig} равна {result}");