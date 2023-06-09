// 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//     в промежутке от N до 1. Выполнить с помощью рекурсии.

int GetInput(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

int numberN = GetInput("Введите целое положительное число: ");
if(numberN < 0) Console.WriteLine("число должно быть положительным");
else NaturalNumbers(numberN);
