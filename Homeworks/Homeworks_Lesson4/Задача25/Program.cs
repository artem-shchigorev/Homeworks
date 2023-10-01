//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double degree(double A, double B)
{
    double degr = Math.Pow(A, B);
    return degr;
}
System.Console.WriteLine("Введите число, возводимое в степень: ");
double a = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
double b = Convert.ToDouble(System.Console.ReadLine());
double DegreeAB = degree(a, b);
System.Console.WriteLine($"Степень {a} от числа {b} = {DegreeAB}");
