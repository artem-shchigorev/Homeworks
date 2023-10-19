//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int EnteringIntValue(string message)
{
    Console.Write(message + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumNumbers(int m, int n)
{
    if (m < n) return m + SumNumbers(m + 1, n);
    else if (m > n) return m + SumNumbers(m - 1, n);
    else return m;
}
Console.WriteLine(SumNumbers(EnteringIntValue("Enter the number m"),
                             EnteringIntValue("Enter the number n")));
