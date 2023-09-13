// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void Cheking (int b1, int b2, int k1, int k2)
{
    if (k1 == k2)
    return "Прямые не пересекаются";

    if (k1 == k2 && b1 == b2)
    return "Прямые совпадают";
}

double[] PointOfMeet (int b1, int b2, int k1, int k2)
{
    double[] arr = new[2];
    arr[0] = (b2-b1)/(k1-k2);
    arr[1] = k1 * arr[0] + b1;     

    return arr[];    
}

void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int b1 = ImputNum("Введите значение b1: ");
int b2 = ImputNum("Введите значение b2: ");
int k1 = ImputNum("Введите значение k1: ");
int k2 = ImputNum("Введите значение k2: ");
Console.WriteLine(PointOfMeet(b1, b2, k1, k2));