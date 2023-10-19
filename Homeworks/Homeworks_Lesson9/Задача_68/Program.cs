//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

//A(0,n) = n+1
//A(m,0) = A(m-1,1)
//A(m,n) = A(m-1,A(m,n-1))

int EnteringIntValue(string message)
{
    Console.Write(message + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
int mNumber = EnteringIntValue("Enter the number m");
int nNumber = EnteringIntValue("Enter the number n");
if (mNumber >= 0 && nNumber >= 0) Console.WriteLine(AckermanFunction(mNumber, nNumber));
else Console.WriteLine("The numbers m and n must not be negative");
