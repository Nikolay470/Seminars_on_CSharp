// 31.
// 1.Задайте массив заполненный случайными числами из промежутка [-9, 9].
// 2.Найдите сумму положительных и отрицательных элементов в массиве.

int[] CreateArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int SumPositiveItems(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
                sum += arr[i]; 
    }
    return sum;
}

int SumNegativeItems(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
                sum += arr[i]; 
    }
    return sum;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
                Console.Write($"{arr[i]}, ");
        else
                Console.Write($"{arr[i]}");
    }
}

int[] arrayRandomNumbers = CreateArray(10, -9, 9);
int sumPositiveElem = SumPositiveItems(arrayRandomNumbers);
int sumNegativeElem = SumNegativeItems(arrayRandomNumbers);

Console.Write("[");
PrintArray(arrayRandomNumbers);
Console.WriteLine("]");

Console.WriteLine($"Сумма положительных элементов массива {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов массива {sumNegativeElem}");