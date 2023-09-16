// Среднее арифметическое каждого столбца

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
        {
            if (i == 0 && j == 0) array[i, j] = 1;
            else if (j == 0) array[i, j] = array[i - 1, m - 1] + k;
            else array[i, j] = array[i, j - 1] + k;
        }

    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

double [] FindAverageInColumns (int[,] matrix)
{
    double[] resultAr = new double[matrix.GetLength(1)];
    
    int index = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            resultAr[index] += matrix [j,i];
        }
    resultAr[index] = resultAr[index]/matrix.GetLength(0);
    index++;
    }

    return resultAr;
}

void PrintListAvr (double[] list)
{
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:f2}\t");
    }
        
}


int n = ImputNum("Введите количество строк: ");
int m = ImputNum("Введите количество столбцов: ");
int k = ImputNum("Введите значение коэффициента k: ");
int[,] array2D = CreateIncreasingMatrix(n, m, k);

PrintArray(array2D);

PrintListAvr(FindAverageInColumns(array2D));