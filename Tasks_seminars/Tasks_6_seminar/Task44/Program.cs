// 44. Не используя рекурсию выведите первые шесть чисел Фибоначи.
//     Первые два числа Фибоначи: 0 и 1.

int GetInput(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int[] NumbersFibonachi(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int number = GetInput("Введите ваше число");
int[] resultArray = NumbersFibonachi(number);
PrintArray(resultArray);