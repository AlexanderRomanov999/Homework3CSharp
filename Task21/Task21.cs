int num1 = 0; int num2 = 0; int num3 = 0; int num4 = 0; int num5 = 0; int num6 = 0;
double distance = CalculateDistance(num1, num2, num3, num4, num5, num6);
Print(distance);

double CalculateDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    Console.WriteLine("Введите координаты первой точки:");
    Console.Write("X: ");
    X1 = int.Parse(Console.ReadLine());
    Console.Write("Y: ");
    Y1 = int.Parse(Console.ReadLine());
    Console.Write("Z: ");
    Z1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки:");
    Console.Write("X: ");
    X2 = int.Parse(Console.ReadLine());
    Console.Write("Y: ");
    Y2 = int.Parse(Console.ReadLine());
    Console.Write("Z: ");
    Z2 = int.Parse(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));
    return distance;  
}

void Print(double distance)
{
    Console.WriteLine(distance);
}