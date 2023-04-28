// Напишите программу которая выводит число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число это {number}");

int maxDigit = MaxDigit(number);

Console.WriteLine($"Наибольшая цифра числа {number} это {maxDigit}");
