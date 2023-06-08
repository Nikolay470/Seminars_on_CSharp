// 41. Пользователь вводит с клавиатуры M чисел. 
//     Посчитайте, сколько чисел больше 0 ввёл пользователь.
//     0, 7, 8, -2, -2 -> 2
//     -1, -7, 567, 89, 223-> 3

int GetInput(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int[] ArrayNumbersFromUser(int sizeArr)
{
    int[] array = new int[sizeArr];
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            int num = GetInput("Введите целое число");
            array[i] = num;
        }
        else
        {
            int num = GetInput("Введите следующее число");
            array[i] = num;
        }

    }
    return array;
}

int QuantytiNumbersAboveZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintNumbers(int[] arr)
{
    Console.WriteLine("Ваш ряд чисел ");
    for (int i = 0; i < arr.Length; i++)
    {
        if( i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
}

int QuantytiNumbers = GetInput("Какое колличество чисел вы хотите ввести?"
                                + " (введите число)");
int[] arrayNumbers = ArrayNumbersFromUser(QuantytiNumbers);
int quantytiNumAboveZero = QuantytiNumbersAboveZero(arrayNumbers);

PrintNumbers(arrayNumbers);
Console.WriteLine($" => {quantytiNumAboveZero} из них больше нуля.");
