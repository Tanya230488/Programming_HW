Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 0;

while (count < number)
{
    if (number % 2 == 0)
    {
        Console.Write ($"{count + 2}, ");
    }    
    else number = number - 1;
    count = count + 2;
}    
