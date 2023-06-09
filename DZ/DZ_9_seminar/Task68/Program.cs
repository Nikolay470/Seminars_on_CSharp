// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//     Даны два неотрицательных числа m и n.

int GetInput(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Ackermann(int paramOne, int paramTwo)
{
    if (paramOne > 0 && paramTwo > 0) return Ackermann(paramOne - 1, Ackermann(paramOne, paramTwo - 1));
    if (paramOne > 0 && paramTwo == 0) return Ackermann(paramOne - 1, 1);
    if (paramOne == 0) return paramTwo + 1;
    return 0; // без return выдает ошибку что не все пути возвращают значение.
}

int numberM = GetInput("Введите первое число (целое, положительное): ");
int numberN = GetInput("Введите второе число (целое, положительное): ");

if (numberM < 0 || numberN < 0) Console.WriteLine("Оба числа должны быть положительными");
else
{
    int result = Ackermann(numberM, numberN);
    Console.WriteLine($"A({numberM}, {numberN}) => {result}");
}