// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    if (num > 0)
    {
        for (int count = 1; count <= num; count++)
        {
            double cube = Math.Pow(count, 3);
            Console.WriteLine($"{count,4} => {cube,7}");
        }
    }
    else
    {
        for (int count = -1; count >= num; count--)
        {
            double cube = Math.Pow(count, 3);
            Console.WriteLine($"{count,4} => {cube,7}");
        }
    }
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine("Введите число отличное от нуля");
else Cube(number);
