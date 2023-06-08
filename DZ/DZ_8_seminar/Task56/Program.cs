// 56: Задайте двумерный массив. Напишите программу, которая будет
//     находить строку с наименьшей суммой элементов.
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

int[] SumItemsRowsMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int SearchLesserSum(int[] arr)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[index])
        {
            index = i;
        }
    }
    return index;
}

int[,] matrixTest = CreateMatrixIntRnd(4, 4, -5, 10);
PrintMatrix(matrixTest);
int[] sumElemRowsMatrix = SumItemsRowsMatrix(matrixTest);
int indexRowWithlesserSum = SearchLesserSum(sumElemRowsMatrix);
Console.WriteLine();
Console.WriteLine($"строка с индексом { indexRowWithlesserSum } имеет "
                    + $"наименьшую сумму { sumElemRowsMatrix[indexRowWithlesserSum] }");