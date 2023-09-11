// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateAr (int size)
{
    return new double[size];
}

void FillArray (double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.NextDouble() + rnd.Next(0, 3), 2);
}

void PrintAr (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double Subtraction (double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }    
    return max - min;        
}

int size = ImputNum("Введите размер массива: ");
double[] arr = CreateAr(size);
FillArray(arr);
PrintAr(arr);
double res = Subtraction(arr);
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + Math.Round(res, 2));