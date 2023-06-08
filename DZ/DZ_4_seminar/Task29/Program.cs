// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] CreateArray(int quant, int min, int max)
{
    int[] arr = new int[quant];
    Random rnd = new Random();

    for (int n = 0; n < quant; n++)
    {
        arr[n] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int n = 0; n < arr.Length; n++)
    {
        if (n < arr.Length - 1) Console.Write($"{arr[n]}, ");
        else Console.Write($"{arr[n]}");
    }
}

Console.WriteLine("Введите колличество элементов в массиве");
int quantityItems = Convert.ToInt32(Console.ReadLine());

if (quantityItems <= 0) Console.WriteLine("Введите целое положительное число");
else
{
    Console.WriteLine("Введите максимальное число которое может быть в массиве");
    int maxNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите минимальное число которое может быть в массиве");
    int minNumber = Convert.ToInt32(Console.ReadLine());

    int[] array = CreateArray(quantityItems, minNumber, maxNumber);
    Console.Write("[");
    PrintArray(array);
    Console.Write("]");
}
