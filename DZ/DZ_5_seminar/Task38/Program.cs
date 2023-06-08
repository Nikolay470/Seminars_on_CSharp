// 38. Задайте массив вещественных чисел. 
//     Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArrayDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max -min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SearshMinItem(double[] arr)
{
    int indexMinItem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < arr[indexMinItem])
            indexMinItem = i;
    }
    return indexMinItem;
}

int SearshMaxItem(double[] arr)
{
    int indexMaxItem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > arr[indexMaxItem])
            indexMaxItem = i;
    }
    return indexMaxItem;
}

void RoundItemsArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i], 1);
    }
}


double[] arrayTest = CreateArrayDouble(5, 1, 100);
int indexMinElem = SearshMinItem(arrayTest);
int indexMaxElem = SearshMaxItem(arrayTest);

double result = arrayTest[indexMaxElem] - arrayTest[indexMinElem];
result = Math.Round(result, 1);
RoundItemsArray(arrayTest);

PrintArray(arrayTest);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным элементом массива и минимальным равна {result}");