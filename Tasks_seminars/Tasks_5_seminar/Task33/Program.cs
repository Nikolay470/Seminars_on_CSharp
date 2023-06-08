// 33. Задайте массив.
//     Напишите программу которая проверяет присутствует ли заданное число в массиве.

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

bool SearchNumberInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
                return true;
    }
    return false; 
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

int GetInput(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int number = GetInput("Введите число которое нужно " +
                      "проверить на наличие в массиве");
int[] arrayTest = CreateArray(10, -10, 10);
bool thereIsNumberInArray = SearchNumberInArray(arrayTest, number);

Console.Write("[");
PrintArray(arrayTest);
Console.WriteLine("]");

Console.WriteLine(thereIsNumberInArray ? $"Число {number} есть в массиве" 
                                       : $"Число {number} отсутствует в массиве");