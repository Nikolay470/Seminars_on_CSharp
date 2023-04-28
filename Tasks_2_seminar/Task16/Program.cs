// Напишите программу которая принимает на вход два числа и
// проверяет является ли одно квадратом второго

bool Square(int num1, int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1) 
    {
        return true;
    } 
    else return false;
}

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = Square(firstNumber, secondNumber);
Console.WriteLine(result ? "да" : "нет");