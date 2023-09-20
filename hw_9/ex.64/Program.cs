// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

string PrintNums (int num)
{
    if (num == 1) return "1";
    return num + ", " + PrintNums(--num);
}

int n = ImputNum("Введите число N: ");
Console.WriteLine(PrintNums(n));