// 42. Напишите программу которая будет преобразовывать десятичное число в двоичное

int GetInput(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

string DecToBin(int num)
{
    string result = String.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}


int number = GetInput("Введите десятичное число "  
                       + "которое нужно преобразовать в двоичное.");
string num = DecToBin(number);
Console.WriteLine($"{num}");