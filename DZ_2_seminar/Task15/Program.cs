// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
bool DefineDayOff(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}

Console.WriteLine("Введите номер дня недели.");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7) Console.WriteLine("Введите коректный номер дня недели.");
else
{
    bool result = DefineDayOff(number);
    Console.WriteLine(result ? "Этот день выходной" : "Этот день будний");
}

