int ImputNum (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int Degree (int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = i * num1;
    }
    return result;
}

int digA = ImputNum("Введите число А: ");
int digB = ImputNum("Введите число B: ");
int result = Degree(digA, digB);
Console.WriteLine($"Число {digA} в степени {digB} равно {result}");