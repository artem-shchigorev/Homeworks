// // void CheckMultiplicity(int num1, int num2)
// // {
// //     if (num1 % num2 == 0)
// //     {
// //         Console.WriteLine($"The number {num2} is a multiple of the number {num1}");
// //     }
// //     else
// //     {
// //         Console.WriteLine($"The number {num2} is not a multiple of the number {num1}, remainder is --> {num1 % num2}");
// //     }
// // }
// // System.Console.Write("Input first num: ");
// // int n1 = Convert.ToInt32(Console.ReadLine());
// // System.Console.Write("Input second num: ");
// // int n2 = Convert.ToInt32(Console.ReadLine());
// // CheckMultiplicity(n1, n2);
// int FindBiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed > dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }

// int num = new Random().Next(10, 100);
// System.Console.WriteLine($"The random number is {num}");
// System.Console.WriteLine($"The number {FindBiggestDigit(num)} is bigger");



// int RundomNumber()
// { 
// int num = new Random().Next(100, 1000);
// return num;
// }
// int FNumber (int RandNum)
// {
//    int FirstNumber = RandNum / 100;
//    return FirstNumber;  
// }
// int SNumber (int RandNum)
// {
//    int SecondNumber = RandNum % 10;
//    return SecondNumber;  
// }
// int RNum = RundomNumber();
// int SN = SNumber(RNum);
// int FN = FNumber(RNum);
// System.Console.WriteLine($"The random number is {RNum}");
// System.Console.WriteLine($"{FN}{SN}");

bool Multiplicity () 
{
    System.Console.Write("Input num: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 && num % 23 ==0)
    {
        return true;
    }
    else 
    {
        return false;
    }
}
System.Console.WriteLine($"{Multiplicity()}");
System.Console.WriteLine($"{Multiplicity()}");
System.Console.WriteLine($"{Multiplicity()}");