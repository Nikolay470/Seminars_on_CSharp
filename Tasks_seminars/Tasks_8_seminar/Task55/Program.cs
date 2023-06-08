// 55: Задайте двумерный массив. Напишите программу,
//     которая заменяет строки на столбцы. В случае, если это
//     невозможно, программа должна вывести сообщение для
//     пользователя
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

void ReplaceRowsOnColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] matrixTest = CreateMatrixIntRnd(4, 4, -10, 10);
if(matrixTest.GetLength(0) == matrixTest.GetLength(1))
{
    PrintMatrix(matrixTest);
    ReplaceRowsOnColumns(matrixTest);
    Console.WriteLine();
    PrintMatrix(matrixTest);
}
else Console.WriteLine("Колличество строк должно соответствовать колличеству столбцов.");