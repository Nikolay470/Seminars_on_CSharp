// 58: Задайте две матрицы. Напишите программу, которая будет
//     находить произведение двух матриц.
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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    // создаем новую матрицу
    int[,] matr = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    // k - это счетчик столбцов второй матрицы
    for (int k = 0; k < matrix2.GetLength(1); k++)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            int m = 0; // счетчик строк второй матрицы
            int multiplication = 0;
            int sum = 0;

            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                // вычисляем значение элемента новой матрицы
                multiplication = matrix1[i, j] * matrix2[m, k];
                sum = sum + multiplication;
                m++; // увеличиваем m что бы проходить по столбцам второй матрицы
            }
            // добавляем элемент в новую матрицу
            matr[i, k] = sum;
        }
    }
    return matr;
}

int[,] firstMatrix = CreateMatrixIntRnd(4, 3, 1, 5);
int[,] secondMatrix = CreateMatrixIntRnd(3, 6, 1, 5);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
// проверяем согласованны ли матрицы.
// если нет выводим соообщение о том что матрицы не согласованны.
// не согласованные матрицы нельзя перемножить.
if(firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] resultMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Результат умножения двух выше описанных матриц.");
    PrintMatrix(resultMatrix);
}
else Console.WriteLine($"Матрицы не согласованны. "
                       + "Колличество столбцов первой матрицы должно "
                       + "совпадать с колличеством строк второй матрицы");