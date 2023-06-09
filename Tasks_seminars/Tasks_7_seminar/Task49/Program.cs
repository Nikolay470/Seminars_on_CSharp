﻿// 49. Задайте двумерный массив размером m x n.
//     Найдите элементы у которых оба индекса четные и
//     замените эти элементы на их квадраты.

int[,] CreateMatrixIntRnd(int rows, int columns, int min, int max)
{
    int[,] arr2d = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            arr2d[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2d;
}

void PrintMatrix(int[,] arr2d)
{
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            Console.Write($"{arr2d[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void ReplaceElementsOnSquares(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *=  matrix[i, j];
        }
    }
}

int[,] matrixTest = CreateMatrixIntRnd(3, 4, 1, 10);
PrintMatrix(matrixTest);

Console.WriteLine();

ReplaceElementsOnSquares(matrixTest);
PrintMatrix(matrixTest);