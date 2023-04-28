// Напишите программу которая принимает на вход два числа 
// и выводит является ли первое кратным второму. Если нет то выводит остаток от деления.

int CompareTwoNumbers(int num1, int num2)
{
return num1 % num2;
}

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = CompareTwoNumbers(firstNumber, secondNumber);
string result = remainder != 0 ? $"Не кратно остаток {remainder}" : "Первое число кратно второму" ;

Console.WriteLine(result);