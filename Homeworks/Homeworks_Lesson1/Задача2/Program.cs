//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    System.Console.WriteLine($"Number --> {num1} <-- is greater!");
    System.Console.WriteLine($"Number --> {num2} <-- is smaller!");
}
else
{
    if (num2 > num1)
    {
        System.Console.WriteLine($"Number --> {num2} <-- is greater!");
        System.Console.WriteLine($"Number --> {num1} <-- is smaller!");
    }
    else
    {
        System.Console.WriteLine($"Number --> {num1} = number {num2} <--");
    }
}
