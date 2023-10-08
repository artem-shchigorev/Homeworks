//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterParameters(string message)
{
    System.Console.WriteLine(message);
    double parameter = Convert.ToDouble(System.Console.ReadLine());
    return parameter;
}
void FindingIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (b1 == 0 && b2 == 0 && k1 != k2) System.Console.WriteLine("Прямые не пересекаются ни в одной точке!");
    else if (b1 == 0 && b2 == 0 && k1 == k2) System.Console.WriteLine("Прямые пересекаются во всех точках!");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        System.Console.WriteLine($"Прямые пересекаются в точке [{x}, {y}]");
    }
}
FindingIntersectionPoint(EnterParameters("Введите b1"), EnterParameters("Введите k1"), EnterParameters("Введите b2"), EnterParameters("Введите k2"));
