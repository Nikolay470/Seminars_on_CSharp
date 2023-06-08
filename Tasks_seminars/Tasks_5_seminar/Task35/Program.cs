// 35. Задайте одномерный массив из 123 случайных чисел.
//     Найдите колличество элементов массива,
//     значения которых лежат в отрезке [10, 99]

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
        if(i < arr.Length - 1)
                Console.Write($"{arr[i]}, ");
        else       
                Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int QuantityTwoDigitNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 9 && arr[i] < 100)
                count++;
    }
    return count;
}

int[] arrayTest = CreateArray(123, -200, 200);
int quantityTwoDigitNum = QuantityTwoDigitNumbers(arrayTest);

PrintArray(arrayTest);
Console.WriteLine($" => {quantityTwoDigitNum}");
