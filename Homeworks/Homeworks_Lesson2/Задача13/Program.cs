//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

bool check(int n) // Метод проверяет, есть ли 3 цифра у числа.
{
    if (n / 100 == 0)
    {
        System.Console.WriteLine("There is no third digit!");
        return false;
    }
    else
    {
        return true;
    }
}

int FindThirdDigit(int n) // Метод возвращает третью цифру заданного числа.
{
    int digit = 100; // Количество нулей в этой переменной будет соответсвовать количеству цифр заданного числа.
    bool a = true;
    while (a == true)
    {
        if (n / digit != 0)
        {
            digit = digit * 10;
        }
        else
        {
            a = false;
        }
    }
    int ThirdDigit = (n / (digit / 1000)) % 10; // digit/1000 - мы отсекаем 3 нуля от переменной digit, так как наша искомая цифра третья слева.
    return ThirdDigit;                          // n/(digit/1000) - получаем число, состоящее из первых трех чисел заданного числа.
}                                               // (n/(digit/1000))%10 - от полученного числа отдеяем остаток от деления на 10.

System.Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool checknum = check(num);
if (checknum == true)
{
    int thirdnum = FindThirdDigit(num);
    System.Console.WriteLine($"{thirdnum}");
}

