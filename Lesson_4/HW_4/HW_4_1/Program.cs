// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// т к возвращает вещественное, то double, иначе бы было integer
// т к работаем с произведением, то double num = 1.

double Stepen(int a, int b)
{
    double n_step = 1;
    int b_step= Math.Abs(b);

    //пошел цикл
    for (int i=1; i<=b_step;i++)
    {
        if (b_step>0)
        n_step *=a;
        else
        n_step /=a;
    }
    return n_step;
    //возвращаем результат
}
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write(Stepen(a,b));


//Console.Write("Введите число A: ");
//int a = int.Parse(Console.ReadLine()!);
//Console.Write("Введите число B: ");
//int b = int.Parse(Console.ReadLine()!);

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//int c = 1;
//if (b < 1)
// Console.Write("Число B должно быть натуральным\n");
//else
//{
  //  while (b != 0)
 //   {
  //      c = c * a;
 //       b = b - 1;
 //   }
  //  Console.Write($"Число A в натуральной степени B равно { c}");
//}