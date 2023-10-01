//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumNumber(int num)
{
    int sum = 0;
    int i = 10;
    do
    {
        sum = sum + (num%i)/(i/10);
        i = i * 10;
    }
    while (num/i !=0);
    sum = sum + (num%i)/(i/10);
    return sum;
}

System.Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Cумма цифр в числе {num} = {sumNumber(num)}");
