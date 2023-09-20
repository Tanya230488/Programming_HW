// упорядочивание строк по убыванию

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
int[,] Create2DAr(int rows, int columns)
{
    return new int[rows, columns];
}
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 100);

}
void Print2DAr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int[] Array1D(int[,] array)
{
    int[] newarray = new int[array.GetLength(1)];
    int index = 0;
            int i = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newarray[index] = array[i, j];
                index++;
            }

    return newarray;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

int[,] Sorted2DArray(int[] array, int rows, int cols)
{
    int[,] sortedArray = new int[rows, cols];
    int count = 0;
    for (int i = 0; i < sortedArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortedArray.GetLength(1); j++)
        {
            sortedArray[i, j] = array[count];
            count++;
        }
    }
    return sortedArray;
}

int[,] SorteringArray(int[,] array)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return res;
}
void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int rows = ImputNum("Введите количество строк: ");
int columns = ImputNum("Введите количество столбцов: ");
int[,] array2D = Create2DAr(rows, columns);


FillArray(array2D);
Print2DAr(array2D);

System.Console.WriteLine();

int[] array1D = Array1D(array2D);
SortArray(array1D);
PrintAr(array1D);

// int[,] result = Sorted2DArray(array1D, rows, columns);
// Print2DAr(result);
