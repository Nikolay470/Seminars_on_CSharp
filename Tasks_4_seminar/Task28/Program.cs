// Напишите программу которая принимает на вход число N 
// и выдает произведение чисел от 1 до N 

int Factorial(int num)
{
    if(num == 1) return 1;
    else 
    {
        checked
        {
            return num * Factorial(num - 1);
        }
    }
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1) Console.WriteLine("Вы ввели некоректное число");
else
{
int compositionNum = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {compositionNum}");
}
