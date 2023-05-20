// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Exponentiate(int num, int deg)
{
    int sum = num;
    for (int n = 1; n < deg; n++)
    {
        sum = sum * num;
    }
    return sum;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень в которую надо возвести число");
int degree = Convert.ToInt32(Console.ReadLine());
if (degree <= 0) Console.WriteLine("Введите степень в виде целого положительного числа");
else
{
    int result = Exponentiate(number, degree);
    Console.WriteLine($"{number} в степени {degree} равно {result}");
}
