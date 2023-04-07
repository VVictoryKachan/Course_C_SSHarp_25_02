﻿// 7.3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNum(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void Average(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double rez;

    for (int i = 0; i < column; i++)
    {
        rez = 0;
        for (int j = 0; j < row; j++) rez = +arr[j, i];
        Console.Write($"{Math.Round(rez / row, 2)} ");
    }
}
Console.Write("Enter the number rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNum(row_num, column_num, start, stop);

Print(mass);

Average(mass);