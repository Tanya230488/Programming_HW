// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        array[i] = new Random().Next(100, 1000);
}

void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int PosAmount (int[] arr)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            amount++;
    }    
    return amount;        
}

int size = ImputNum("Введите размер массива: ");
int[] arr = CreateAr(size);
FillArray(arr);
PrintAr(arr);
int res = PosAmount(arr);
Console.WriteLine("Количество четных чисел в массиве равно " + res);