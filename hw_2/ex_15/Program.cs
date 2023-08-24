int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string CheckWeekend (int num)
{
    if (num < 6)
        return "Нет";
    else 
        return "Да";    
}

void PrintRes (string res)
{
    Console.WriteLine(res);
}


int number = InputNum("Введите число: ");
PrintRes (CheckWeekend(number));