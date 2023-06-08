// Напишите программу, которая принимает на вход целое число и
// выдает является ли оно четным или нет.

Console.WriteLine("Введите целое число.");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine($"Число {number} четное");
else Console.WriteLine($"Число {number} не является четным");