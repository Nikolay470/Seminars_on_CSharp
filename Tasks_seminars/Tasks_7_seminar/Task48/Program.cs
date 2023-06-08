// 48. Задайте двумерный массив размером m x n.
//     Каждый элемент в массиве находится по формуле Аmn = m + n.
//     Выведите полученный массив на экран.

int[,] CreateMatrixByIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[,] matrixTest = CreateMatrixByIndex(4, 5);
PrintMatrix(matrixTest);