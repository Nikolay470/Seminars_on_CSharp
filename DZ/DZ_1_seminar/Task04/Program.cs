// Напишите программу, которая принимает на вход три числа и
// выдает максимальное из этих чисел.

Console.WriteLine("Введите первое целое число.");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число.");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber; 

Console.WriteLine("Максимальное число " + max);