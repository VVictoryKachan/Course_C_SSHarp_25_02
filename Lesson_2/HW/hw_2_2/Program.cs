// Написать программу которая выводит 3-ью цифру заданного числа
//или сообщает что третьей цифры нет

void ThirdDigit (int num)
{
    //Console.Write($"{num} ");
    if (num<100) 
    { Console.Write("is not third digit");
    return;
    }
    while (num>999) num/=10;
    Console.WriteLine(num%10);
}
ThirdDigit (int.Parse(Console.ReadLine()!));