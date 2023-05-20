// Напишите программу которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке

void FillArray(int[] arr)
{
    var random = new Random();
    for (int n = 0; n < arr.Length; n++)
    {
        arr[n] = random.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int n = 0; n < arr.Length; n++)
    {
        if (n < arr.Length - 1) Console.Write($"{arr[n]}, ");
        else Console.Write($"{arr[n]}");
    }
}

int[] CreateArray(int leng)
{
    int[] arr = new int[leng];
    return arr;
}

Console.WriteLine("Введите колличество элементов в массиве (числом)");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Введите целое положительное число");
else
{
    int[] array = CreateArray(number);
    FillArray(array);

    Console.Write("[");
    PrintArray(array);
    Console.Write("]");
}
