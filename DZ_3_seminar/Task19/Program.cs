// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

int Reverse(int num)
{
    int reverse = 0;
    while (num > 0)
    {
        int remainder = num % 10;
        reverse = (reverse * 10) + remainder;
        num /= 10;
    }
    return reverse;
}

bool Palindrom(int num, int rev)
{
    if (num == rev) return true;
    else return false;
}


Console.WriteLine("Введите ваше число.");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number == 0) Console.WriteLine("Введите число отличное от нуля.");
else
{
    int numberReverse = Reverse(number);
    bool result = Palindrom(number, numberReverse);
    Console.WriteLine(result ? "да" : "нет");
}
