// 3. Напишите программу, которая принимает на вход число (N)
//    и выдаёт таблицу кубов чисел от 1 до N.

    void Kub (int num)
{
    double[] nums = new double[num];
    int index = 0;

    Console.Write($"{num} -> ");

    while (index < num)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

Kub(int.Parse(Console.ReadLine()!));
