// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//     заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//     значения b1, k1, b2 и k2 задаются пользователем.
//     b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int angularCoeff = 0; // угловой коэффициент
int freeCoeff = 1; // свободный коэффицент
int coordX = 0; // координата Х точки пересечения
int coordY = 1; // координата Y точки пересечения

double GetInputDouble(string message)
{
    Console.WriteLine(message);
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}
// метод получения коэффициентов от пользователя
void DataLine(string message, double[] arr)
{
    Console.WriteLine(message);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            arr[angularCoeff] = GetInputDouble("Ввведите угловой коэффициент");
        }
        else
        {
            arr[freeCoeff] = GetInputDouble("Ввведите свободный коэффициент");
        }
    }
}
// метод поиска координат точки пересечения
double[] SearchCoordinates(double[] arrFirst, double[] arrSecond)
{
    double coordinateX = (arrFirst[freeCoeff] - arrSecond[freeCoeff])
                            / (arrSecond[angularCoeff] - arrFirst[angularCoeff]);
    double coordinateY = arrFirst[angularCoeff] * coordinateX + arrFirst[freeCoeff];

    return new double[2] { coordinateX, coordinateY };
}
// метод проверяет пересекаются прямые или нет
bool ValidateIntersectionLine(double[] arrFirst, double[] arrSecond)
{
    if (arrFirst[angularCoeff] == arrSecond[angularCoeff])
    {
        if (arrFirst[freeCoeff] == arrSecond[freeCoeff])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
// метод округляет координаты точки пересечения до 1 знака после запятой
void RoundCoordinates(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i], 1);
    }
}
// создаем массивы в которых будут хранится коэффициенты прямых
double[] dataFirstLine = new double[2];
double[] dataSecondLine = new double[2];
// получаем от пользователя коэффициенты прямых и ложим их в соответствующие массивы
DataLine("Введите коэффициенты для первой прямой", dataFirstLine);
DataLine("Введите коэффициенты для второй прямой", dataSecondLine);
// проверяем пересекаются ли прямые
bool resultValidate = ValidateIntersectionLine(dataFirstLine, dataSecondLine);
// если пересекаются, выполняем программу 
if (resultValidate)
{
    double[] coordPointIntersection = SearchCoordinates(dataFirstLine, dataSecondLine);
    RoundCoordinates(coordPointIntersection);
    Console.WriteLine("Координаты точки пересечения прямых "
                       + $"({coordPointIntersection[coordX]}; {coordPointIntersection[coordY]})");
}