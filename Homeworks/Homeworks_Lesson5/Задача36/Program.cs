//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
void SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве = {sum}");
    System.Console.WriteLine();
}
int[] arr = CreateArray(EnterParameters("Введите длину массива: "), EnterParameters("Введите минимальное значение массива:"), EnterParameters("Введите максимальное значение массива:"));
SumOddIndex(arr);