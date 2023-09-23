//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondDigit (int n)
{
    if (n/100 != 0 && n/1000 == 0)
    {
        int secondnum = n/10%10;
        System.Console.WriteLine($"the second digit of your number --> {secondnum}");
    }
    else
    {
        System.Console.WriteLine("Your number is not three digit!");
    }
    
}

System.Console.WriteLine("Enter your three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondDigit(num);
