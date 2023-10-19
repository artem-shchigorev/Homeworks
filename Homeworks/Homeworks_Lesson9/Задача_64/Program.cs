//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnteringIntValue(string message)
{
    Console.Write(message + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void ShowNumbers(int n)
{
    if(n >= 1)
    {
        Console.Write(n + " ");
        ShowNumbers(n-1);
    }
}
ShowNumbers(EnteringIntValue("Enter a number"));
