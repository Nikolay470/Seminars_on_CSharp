// 51. Задайте двумерный массив.
//     Найдите сумму элементов находящихся на главной диагонали.

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

int SumElementsOnDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i]; 
    }
    return sum;
}

int[,] matrixTest = CreateMatrixIntRnd(3, 4, 1, 10);
int sumElemOnDiagonal = SumElementsOnDiagonal(matrixTest);
PrintMatrix(matrixTest);
Console.WriteLine();
Console.WriteLine($"Сумма элементов находящихся на главной диагонали равна {sumElemOnDiagonal}");