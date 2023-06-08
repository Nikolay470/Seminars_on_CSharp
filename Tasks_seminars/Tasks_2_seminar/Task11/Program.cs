// Напишите программу которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

int RemoveSecondNumber(int num)
{
int firstDigit = num / 100;
int thirdDigit = num % 10;

int result = firstDigit * 10 + thirdDigit;
return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число это {number}");

int resultNumber = RemoveSecondNumber(number);

Console.WriteLine($"После удаления второй цифры получаем число {resultNumber}");