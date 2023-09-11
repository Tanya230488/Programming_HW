// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateAr (int size)
{
    return new int[size];
}

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(101);
}

void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOddIndex (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 > 0)
            sum += arr[i];
    }    
    return sum;        
}

int size = ImputNum("Введите размер массива: ");
int[] arr = CreateAr(size);
FillArray(arr);
PrintAr(arr);
int res = SumOddIndex(arr);
Console.WriteLine("Сумма чисел с нечетными индексами в массиве равна " + res);