// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] CreateArray(int quant)
{
    int[] arr = new int[quant];
    Random rnd = new Random();

    for (int n = 0; n < quant; n++)
    {
        arr[n] = rnd.Next(1, 100);
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
    int[] array = CreateArray(quantityItems);
    Console.Write("[");
    PrintArray(array);
    Console.Write("]");
}
