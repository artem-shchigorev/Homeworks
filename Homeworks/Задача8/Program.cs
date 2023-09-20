//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Условие задачи подразумевает, что пользователь должен ввести число, больше 1.
System.Console.WriteLine("Input your number greater than 1:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (num < 2)
{
    System.Console.WriteLine("Your number is less than or equal to 1!");
    System.Console.WriteLine("Input your number greater than 1:");
    num = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine($"Even numbers from 1 to {num}: ");
while (i <= num)
{
    System.Console.Write($"{i} ");
    i = i + 2;
}
