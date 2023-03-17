//Написать программу, которая на вход принимает 2 числа и выдаёт, 
// какое число большее, а какое меньшее.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a>b)
{
    Console.Write($"{a} is biggest than {b}");
}
else if (a==b)
{
    Console.Write($"{a} is equal tj the number {b}");
}
else 
{
    Console.Write($"{b} is greater than {a}");
}