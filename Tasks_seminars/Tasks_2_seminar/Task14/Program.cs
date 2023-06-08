// Напишите программу которая принимает на вход число и проверяет является ли
// оно кратным одновременно 7 и 23

bool CompareMultiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CompareMultiplicity(number);

Console.WriteLine(result ? "да" : "нет");
