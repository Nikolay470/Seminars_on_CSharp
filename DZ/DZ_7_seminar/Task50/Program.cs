// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//     и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int GetInput(string message)
{
    Console.Write(message + ": ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

void Eror(int indRow, int indColumn)
{
    Console.WriteLine($"Элемента с индексами [{indRow}, {indColumn}] "
                           + "в матрице не существует.");
}

int[,] matrixTest = CreateMatrixIntRnd(3, 4, -10, 10);
int indexRow = GetInput("Введите индекс строки элемента");
int indexColumn = GetInput("Введите индекс колонки элемента");

PrintMatrix(matrixTest);

if (indexRow < matrixTest.GetLength(0) && indexRow >= 0)
{
    if (indexColumn < matrixTest.GetLength(1) && indexColumn >= 0)
    {
        Console.WriteLine($"На позиции [{indexRow}, {indexColumn}] "
                             + $" лежит элемент {matrixTest[indexRow, indexColumn]}");
    }
    else Eror(indexRow, indexColumn);
}
else Eror(indexRow, indexColumn);