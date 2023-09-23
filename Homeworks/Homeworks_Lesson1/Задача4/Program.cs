//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input third number:");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1>num2){
    if (num1>num3){
        System.Console.WriteLine($"The max number is --> {num1}!");
    } else {
        System.Console.WriteLine($"The max number is --> {num3}!");
    }
} else {
    if (num2>num3){
        System.Console.WriteLine($"The max number is --> {num2}!");
    } else {
        System.Console.WriteLine($"The max number is --> {num3}!");
    }
}