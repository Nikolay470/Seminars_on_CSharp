// Напишите программу которая принимает на вход число А
// и выдает сумму чисел от 1 до А

int sumNumbers(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) Console.WriteLine("Введите положительное число");
else
{
    int sum = sumNumbers(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
}
