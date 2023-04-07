﻿// 7.2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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

string Element(int[,] arr, int first, int second)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (first > row || first <= 0 || second > column || second <= 0)
        return $"{first} {second} not in the array";
    return $"arr[{first}, {second}] = {arr[first - 1, second - 1]} is in the array";
}

Console.Write("Enter the number rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNum(row_num, column_num, start, stop);

Print(mass);

Console.Write("Enter the position: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine()!);

string itog = Element(mass, first, second);
Console.WriteLine(itog);