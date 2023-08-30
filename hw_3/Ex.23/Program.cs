int InputNum (string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Cubes(int num)
{
    for(int i = 1; i < num; i++)
    {
        int cube = (int) Math.Pow(i, 3);
        Console.Write($"{cube}, ");

    }

    int cube2 = (int) Math.Pow(num, 3);
    Console.Write($"{cube2}");
}

int num = InputNum("Введите число: ");
Cubes(num);
