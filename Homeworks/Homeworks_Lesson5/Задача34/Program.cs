//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int EnterParameters(string message)
{
    System.Console.WriteLine();
    System.Console.WriteLine(message);
    System.Console.WriteLine();
    int parameter = Convert.ToInt32(System.Console.ReadLine());
    return parameter;
}
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    System.Console.WriteLine();
    System.Console.WriteLine($"Создан массив из {size} элементов, заполненный случайными числами из промежутка [{minValue},{maxValue}]");
    System.Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    return array;
}
void EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чётных чисел в массиве = {count}");
    System.Console.WriteLine();
}
int[] arr = CreateArray(EnterParameters("Введите длину массива: "), EnterParameters("Введите минимальное значение массива:"), EnterParameters("Введите максимальное значение массива:"));
EvenNumbers(arr);