// 52. Задайте двумерный массив из целых чисел. 
//     Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrixIntRnd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

double[] SearchAverageArithmetic(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arr[j] = sum / matrix.GetLength(0);
    }
    return arr;
}

void PrintAverageArithmetic(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

void RoundAverageArithmetic(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i], 2);
    }
}

int[,] matrixTest = CreateMatrixIntRnd(3, 4, -10, 10);
double[] averageArithmetic = SearchAverageArithmetic(matrixTest);
RoundAverageArithmetic(averageArithmetic);

PrintMatrix(matrixTest);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов матрицы.");
PrintAverageArithmetic(averageArithmetic);
