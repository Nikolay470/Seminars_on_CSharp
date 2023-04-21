Console.WriteLine("Введите первое число (целое).");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (целое).");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) {
    Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}");
} else {
    Console.WriteLine($"Число {firstNumber} НЕ является квадратом числа {secondNumber}");
}