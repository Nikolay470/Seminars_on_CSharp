Console.WriteLine("Введите целое число.");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    for(int count = -number; count <= number; count++) 
    {
        Console.Write(count + " ");
    }
} 
else 
{
    for(int count = number; count <= -number; count++) 
    {
        Console.Write(count + " ");
    }
}
