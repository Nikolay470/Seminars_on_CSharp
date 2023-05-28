// 40. Напишите программу которая принимает на вход три числа
//     и проверяет может ли существовать треугольник со сторонами такой длинны. 
int GetInput(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool IsTriangle(int side1, int side2, int side3)
{
    if (side1 < (side2 + side3) 
            && side2 < (side1 + side3)
            && side3 < (side1 + side2)) return true;
    else return false;
}

int oneSide = GetInput("Введите первое число");
int twoSide = GetInput("Введите второе число");
int threeSide = GetInput("Введите третье число");

bool result = IsTriangle(oneSide, twoSide, threeSide);

Console.WriteLine(result ? "да" : "нет");