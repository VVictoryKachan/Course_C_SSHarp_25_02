// написать программу которая на вход принимает число и выдаёт,
// является ли число четным

int A = int.Parse(Console.ReadLine()!);
if (A%2==0)
{
    Console.Write($"{A} четное");
}
else
{
    Console.Write($"{A} нечетное");
}