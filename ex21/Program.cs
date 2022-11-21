Console.Clear();
System.Console.WriteLine("Расстояние между двумя точками в трехмерном пространстве.");

double x1 = InputCoordinate("X1: ");
double y1 = InputCoordinate("Y1: ");
double z1 = InputCoordinate("Z1: ");
double x2 = InputCoordinate("X2: ");
double y2 = InputCoordinate("Y2: ");
double z2 = InputCoordinate("Z2: ");

System.Console.WriteLine($"Расстояние между двумя точками = {DisPoint(x1, y1, z1, x2, y2, z2)}");

static double InputCoordinate(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine() ??"");
}

static double DisPoint(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}
