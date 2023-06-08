// Напишите программу, которая принимает на вход число N, а на выходе
// выдает все четные числа от 1 до N.

Console.WriteLine("Введите целое положительное число.");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Введите корректное число.");

for (int count = 2; count <= number; count += 2)
{
    Console.Write(count + " ");
}