//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Подразумевается, что пользователь вводит число больше 1 или меньше -1.
System.Console.WriteLine("Input your number greater than 1 or less than -1:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
System.Console.WriteLine($"Even numbers from 1 to {num}: ");
if (num > 1)
{
    i = 2;
    while (i <= num)
    {
        System.Console.Write($"{i} ");
        i = i + 2;
    }
}
else
{
    i = -2;
    while (i >= num)
    {
        System.Console.Write($"{i} ");
        i = i - 2;
    }

}
