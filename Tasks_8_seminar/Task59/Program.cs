// 59: Задайте двумерный массив из целых чисел. Напишите
//     программу, которая удалит строку и столбец, на пересечении которых
//     расположен наименьший элемент массива.

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

int[] PositionMinItem(int[,] matrix)
{
    int minItem = matrix[0, 0];
    int rowMinItem = 0;
    int columnMinItem = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minItem)
            {
                minItem = matrix[i, j];
                rowMinItem = i;
                columnMinItem = j;
            }
        }
    }
    return new int[] { rowMinItem, columnMinItem };
}

int[,] NewMatrix(int[,] matrix, int rowMinElm, int columnMinElem)
{
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1) - 1;
    int[,] newMatr = new int[rows, columns];

    int rowDefaultMatr = 0;
    int columnDefaultMatr = 0;

    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        if (rowDefaultMatr == rowMinElm) rowDefaultMatr++;
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            if (columnDefaultMatr == columnMinElem) columnDefaultMatr++;
            newMatr[i, j] = matrix[rowDefaultMatr, columnDefaultMatr];
            columnDefaultMatr++;
        }
        columnDefaultMatr = 0;
        rowDefaultMatr++;
    }
    return newMatr;
}

int[,] matrixTest = CreateMatrixIntRnd(4, 3, -10, 10);
PrintMatrix(matrixTest);
int[] posMinElement = PositionMinItem(matrixTest);
int[,] newMatrix = NewMatrix(matrixTest, posMinElement[0], posMinElement[1]);
Console.WriteLine();
PrintMatrix(newMatrix);