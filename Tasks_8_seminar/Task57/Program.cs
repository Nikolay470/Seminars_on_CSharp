// 57: Составить частотный словарь элементов
//     двумерного массива. Частотный словарь содержит
//     информацию о том, сколько раз встречается элемент
//     входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[n] = matrix[i, j];
            n++;
        }
    }
    return arr;
}

void FrequencyDictionary(int[,] matrix)
{
    int[] arr = MatrixToArray(matrix);
    Array.Sort(arr);

    int item = arr[0];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == item) count++;
        else
        {
            Console.WriteLine($"Элемент {item} встречается {count} раз");
            count = 1;
            item = arr[i];
        }
    }
}

int[,] matrixTest = CreateMatrixIntRnd(4, 3, 1, 10);
PrintMatrix(matrixTest);
Console.WriteLine();
FrequencyDictionary(matrixTest);