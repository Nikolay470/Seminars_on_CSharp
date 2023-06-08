// Напишите программу, которая на вход принимает два числа и выдает
// какое больше, а какое меньше.

Console.WriteLine("Введите первое число.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) 
{
Console.WriteLine("Большее число " + firstNumber);
Console.WriteLine("Меньшее число " + secondNumber);
}
else 
{
Console.WriteLine("Большее число " + secondNumber);
Console.WriteLine("Меньшее число " + firstNumber);
}