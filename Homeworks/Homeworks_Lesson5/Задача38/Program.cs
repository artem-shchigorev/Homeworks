//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int EnterParameters(string message)
{
    System.Console.WriteLine();
    System.Console.WriteLine(message);
    System.Console.WriteLine();
    int parameter = Convert.ToInt32(System.Console.ReadLine());
    return parameter;
}
double[] CreateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    double fractional = 0;
    System.Console.WriteLine();
    System.Console.WriteLine($"Создан массив из {size} элементов, заполненный случайными вещественными числами из промежутка [{minValue},{maxValue}]");
    System.Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        fractional = new Random().NextDouble();
        array[i] = new Random().Next(minValue, maxValue);
        array[i] += fractional;
        Console.WriteLine($"{array[i]} ");
    }
    System.Console.WriteLine();
    return array;
}
double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальное число в массиве = {min}");
    System.Console.WriteLine();
    return min;
}
double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Максимальное число в массиве = {max}");
    System.Console.WriteLine();
    return max;
}
void Difference(double max, double min)
{
    double diff = max - min;
    System.Console.WriteLine();
    System.Console.WriteLine($"Разница между {max} и {min} = {diff}");
    System.Console.WriteLine();
}

double[] arr = CreateArray(EnterParameters("Введите длину массива: "), EnterParameters("Введите минимальное значение массива:"), EnterParameters("Введите максимальное значение массива:"));
Difference(MaxNumber(arr), MinNumber(arr));

