// Напишите программу которая принимает на вход число
// и выводит колличество цифр в числе


int QuantityNumbers(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0) Console.WriteLine($"{number} => 1");
else
{
    int quantityNum = QuantityNumbers(number);
    Console.WriteLine($"{number} => {quantityNum}");
}

