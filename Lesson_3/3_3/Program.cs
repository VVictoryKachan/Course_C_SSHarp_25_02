// 3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

void Kvadrat(int num)
{
    for (int i = 0; i <= num; i++)
    { Console.WriteLine(i * i + ", "); }
}
int x = int.Parse(Console.ReadLine()!);
Kvadrat(x);