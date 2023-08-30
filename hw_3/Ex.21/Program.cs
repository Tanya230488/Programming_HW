int[] Coor(string msg)
{
    int[] coordinates = new int[3];
    Console.Write($"{msg} X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);

    Console.Write($"{msg} Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);

    Console.Write($"{msg} Z: ");
    coordinates[2] = int.Parse(Console.ReadLine()!);

    return coordinates;
}

double Distance (int[] coorA, int[] coorB)
{
    double res = Math.Sqrt(Math.Pow((coorB[0] - coorA[0]),2) + Math.Pow((coorB[1] - coorA[1]),2) + Math.Pow((coorB[2] - coorA[2]),2));
    return res;
}

int[] coorA = Coor("Введите для точки А координату");
int[] coorB = Coor("Введите для точки B координату");

double dist = Distance (coorA, coorB);
Console.Write(dist);

