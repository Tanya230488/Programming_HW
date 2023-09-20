// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int Ack (int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return Ack (num1 - 1, 1);
    else
    return Ack(num1 - 1, Ack(num1, num2-1));
}

int m = ImputNum("Введите число m: ");
int n = ImputNum("Введите число n: ");
Console.WriteLine(Ack(m, n));