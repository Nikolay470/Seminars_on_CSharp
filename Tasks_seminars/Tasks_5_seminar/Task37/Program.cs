// 37. Найти произведение пар чисел в одномерном массиве.
//     Парой считаем первый и последний элементы, второй и предпоследний и т.д.
//     Результат записать в новом массиве.

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

int[] arrayProductNumbers(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 1)
        size = arr.Length / 2 + 1;
    else
        size = arr.Length / 2;

    int[] array = new int[size];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        array[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1)
        array[array.Length - 1] = arr[arr.Length / 2];
    return array;
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

int[] arrayTest = CreateArray(7, -10, 10);
PrintArray(arrayTest);

Console.Write(" => ");

int[] newArray = arrayProductNumbers(arrayTest);
PrintArray(newArray);
