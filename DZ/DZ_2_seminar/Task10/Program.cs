// Задача 10: Напишите программу,которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int SearchSecondDigit(int num)
{
    int result = (num / 10) % 10;
    if(result < 0)
    {
        result *= -1;
    }
    return result;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000 || number < -99 && number > -1000)
{
    int secondDigit = SearchSecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} это {secondDigit}");
}
else Console.WriteLine("Введите коректное число");

