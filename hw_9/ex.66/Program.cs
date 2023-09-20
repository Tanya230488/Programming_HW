// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SumOfNums (int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + SumOfNums(++num1, num2);
}

int m = ImputNum("Введите число M: ");
int n = ImputNum("Введите число N: ");
Console.WriteLine($"Сумма чисел в промежутке между числом {m} и числом {n} равна {SumOfNums(m, n)}");