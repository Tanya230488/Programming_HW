int ImputNum (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void Array(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(100);
         Console.Write(" " + array[i]);
    }
   
}
int size = ImputNum("Введиче количество элементов в массиве: ");
Array(size);
