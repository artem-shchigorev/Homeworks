// System.Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Your num is -> " + num);
// System.Console.WriteLine("Input number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"The square of {num1} is -> {num1*num1}"); 
System.Console.WriteLine("Input two numbers:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int quad = num2 * num2;
if (quad == num1)
{
    System.Console.WriteLine($"The number {num1} is quad {num2}");
}
else
{
    System.Console.WriteLine($"The number {num1} is not quad {num2}");
}