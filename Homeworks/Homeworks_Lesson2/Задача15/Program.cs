//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Считаем, что выходные дни у нас суббота и воскресенье, что соответствует числам 6 и 7.

bool DayOff (int n)
{
    if (n==6 || n==7)
    {
        return true;
    }
    else
    {
        return false;     
    }
}

System.Console.WriteLine("Enter the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool day = DayOff(num);
System.Console.WriteLine($"Your day is --> {day} <-- day off!"); // по сути выводит такое сообщение пользователю: 
                                                                 // ваш введенный день настоящий выходной или фальщивый выходной