// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int SumNumbers(int num)
{
    if (num < 0) num *= -1;
    int remainder = 0;
    int sum = 0;
    while(num > 0)
    {
        remainder = num % 10;
        sum = sum + remainder;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число отличное от нуля");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}");