// 66: Задайте значения M и N. Напишите программу, 
//     которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetInput(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNaturalNumbers(int numM, int numN)
{
    if (numM > numN) return numM + SumNaturalNumbers(numM - 1, numN);
    else if (numM < numN) return numN + SumNaturalNumbers(numM, numN - 1);
    else return numM;
}

int numberM = GetInput("Введите первое число (целое, положительное): ");
int numberN = GetInput("Введите второе число (целое, положительное): ");

if (numberM < 0 || numberN < 0) Console.WriteLine("Числа должны быть положительные");
else
{
    int resultSum = SumNaturalNumbers(numberM, numberN);
    Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} "
                       + $"равна {resultSum}");
}