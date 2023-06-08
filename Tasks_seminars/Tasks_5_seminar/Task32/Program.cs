// 32. Напишите программу замены элементов массива.
//     Положительные элементы заменить на соответствующие отрицательные
//     и наооборот.
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

void ReplaceElementsToOpposite(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;        
    }
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

int[] arrayTest = CreateArray(7, -10, 10);

Console.Write("[");
PrintArray(arrayTest);
Console.WriteLine("]");

ReplaceElementsToOpposite(arrayTest);

Console.Write("[");
PrintArray(arrayTest);
Console.WriteLine("]");