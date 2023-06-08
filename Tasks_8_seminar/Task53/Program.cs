// 53: Задайте двумерный массив. Напишите программу,
//     которая поменяет местами первую и последнюю строку
//     массива.

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

void ReplaceFirstRowOnLastRow(int[,] matrix)
{
    int indexFirstRow = 0;
    int indexLastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[indexFirstRow, j];
        matrix[indexFirstRow, j] = matrix[indexLastRow, j];
        matrix[indexLastRow, j] = temp;
    }
}

int[,] matrixTest = CreateMatrixIntRnd(3, 4, -10, 10);
PrintMatrix(matrixTest);
Console.WriteLine();
ReplaceFirstRowOnLastRow(matrixTest);
PrintMatrix(matrixTest);
