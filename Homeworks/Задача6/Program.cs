//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Input your number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    System.Console.WriteLine($"The number {num} is even.");
}
else { System.Console.WriteLine($"The number {num} is odd."); }
