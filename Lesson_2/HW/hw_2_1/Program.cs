// написать программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

string NumberDigit(int num)
{
    if ((num > -1000 && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "the number is not digit";
}
//NumberDigit = int.Parse(Console.ReadLine()!);
//Console.WriteLine(NumberDigit);
Console.WriteLine(NumberDigit(int.Parse(Console.ReadLine()!)));