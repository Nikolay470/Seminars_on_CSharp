// 36. Задайте одномерный массив, заполненный случайными числами. 
//     Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
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

int SumItemsOnOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] arrayTest = CreateArray(7, 1, 10);
PrintArray(arrayTest);

Console.WriteLine();
int result = SumItemsOnOddIndex(arrayTest);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {result}");