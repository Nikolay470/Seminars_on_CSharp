// Напишите программу которая выводит число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число это {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа {number} это {result}");