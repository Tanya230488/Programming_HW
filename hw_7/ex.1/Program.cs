// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] array = new double[m,n];

    Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i,j] = rnd.Next(minLimitRandom, maxLimitRandom -1) + rnd.NextDouble();

    return array;            
}

// void FillArray(int[,] array, int minLimitRandom, int maxLimitRandom)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = rnd.Next(minLimitRandom, maxLimitRandom -1);
// }

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]:f1} ");
        Console.WriteLine();
    }
}


int m = ImputNum("Введите количество строк: ");
int n = ImputNum("Введите количество столбцов: ");
int min = ImputNum("Введите минимальное значение диапазона: ");
int max = ImputNum("Введите максимальное значение диапазона: ");
double[,] array2D = CreateRandomMatrix(m, n, min, max);

PrintArray(array2D);