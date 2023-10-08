//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int EnterParameters(string message)
{
    System.Console.WriteLine(message);
    int parameter = Convert.ToInt32(System.Console.ReadLine());
    return parameter;
}
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = EnterParameters($"Введите ваше {i+1}-ое число: ");
    }
    return array;
}
void NumberOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    System.Console.WriteLine($"Количество положительных введенных чисел --> {count}");
}
int[] arr = CreateArray(EnterParameters("Введите количество вводимых чисел: "));
NumberOfPositiveNumbers(arr);