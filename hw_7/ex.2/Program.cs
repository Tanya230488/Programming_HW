// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

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
            Console.Write($"{matrix[i, j]}\t ");
        Console.WriteLine();
    }
}

int[] FindNumberByPosition(int[,] matrix,int rowPosition,int columnPosition)
{
    int[] resultAr = new int[2];

    if (matrix.GetLength(0) < rowPosition || matrix.GetLength(1) < columnPosition)
    {
        resultAr[0] = 0;
        resultAr[1] = 0;
    }    
    else 
    {
        resultAr[0] = matrix[rowPosition-1,columnPosition-1];
        resultAr[1] = 0; 
    }
    return resultAr;
}

void PrintCheckIfError (int[] results,int X,int Y)
{
    if (results[0] == 0)
        Console.Write("There is no such index");
     
    else
        Console.Write($"The number in [{X}, {Y}] is {results[0]}"); 
        
}


int n = ImputNum("Введите количество строк: ");
int m = ImputNum("Введите количество столбцов: ");
int k = ImputNum("Введите значение коэффициента k: ");
int[,] array2D = CreateIncreasingMatrix(n, m, k);

PrintArray(array2D);

int row = ImputNum("Введите значение строки искомого элемента: ");
int collumn = ImputNum("Введите значение столбца искомого элемента: ");

PrintCheckIfError((FindNumberByPosition(array2D, row, collumn)), row, collumn);