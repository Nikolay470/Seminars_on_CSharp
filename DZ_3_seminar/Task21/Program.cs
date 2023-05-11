// Задача 21
// Напишите программу,
// которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

double Distance(int[] array1, int[] array2)
{
    double squareX = (array1[0] - array2[0]) * (array1[0] - array2[0]);
    double squareY = (array1[1] - array2[1]) * (array1[1] - array2[1]);
    double squareZ = (array1[2] - array2[2]) * (array1[2] - array2[2]);

    double result = Math.Sqrt(squareX + squareY + squareZ);
    return result;
}

int[] Coordinates()
{
    Console.Write("X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int z = Convert.ToInt32(Console.ReadLine());

    int[] array = {x, y, z};
    return array;
}

Console.WriteLine("Введите координаты первой точки");
int[] firstPoint = Coordinates();
Console.WriteLine("Введите координаты второй точки");
int[] secondPoint = Coordinates();

double distance = Distance(firstPoint, secondPoint);
distance = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками в 3D пространстве => {distance}");