int InputNum(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

// void FindNum(int num)
// {
//     int firstnum = num / 10000;
//     Console.WriteLine(firstnum);

//     int secondnum = num / 1000 % 10;
//     Console.WriteLine(secondnum);

//     int fourthnum = num / 10 % 10;
//     Console.WriteLine(fourthnum);

//     int fifthnum = num % 10;
//     Console.WriteLine(fifthnum);
// }



bool Palindrom(int number)
{
    if (number > 9999 || number < 1000000)
        Console.WriteLine("Число не пятизначное");
    
    int firstnum = number / 10000;
    int secondnum = number / 1000 % 10;
    int fourthnum = number / 10 % 10;
    int fifthnum = number % 10;

    if (firstnum == fifthnum && secondnum == fourthnum)
        return true; 
           
    else 
        return false;    

}


int num = InputNum("Введите число: ");
bool res = Palindrom(num);
Console.WriteLine(res);

