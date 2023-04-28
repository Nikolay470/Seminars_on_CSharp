// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
int SearchThirdDigit(int num)
{
    int result = num % 10;
    return result;
}

void ConsoleOutput(int num)
{
    int thirdDigit = SearchThirdDigit(num);
    Console.WriteLine($"Третья цифра числа это {thirdDigit}");
}

Console.WriteLine("Введите ваше число.");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0 ) number *= -1;
if(number < 100) Console.WriteLine("Третьей цифры нет.");
else if(number > 99 && number < 1000)
{
   ConsoleOutput(number); 
}
else 
{
    while(number > 1000)
    {
        number = number / 10;
    }
   ConsoleOutput(number); 
}