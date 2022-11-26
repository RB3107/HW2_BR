// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*bool day_of_the_week(int day)
{
if(day >= 6 && day <= 7)
{
return true;
 }
else
{
return false;
}
}
Console.WriteLine($"Введите цифру, обозначающую день недели");
int DayWeek=Convert.ToInt32(Console.ReadLine());
if (DayWeek<8)
{
bool days_of_the_weeks = day_of_the_week(DayWeek);
if (days_of_the_weeks==true)
{
Console.WriteLine($"День недели {DayWeek} выходной");
}
else
{
Console.WriteLine($"День недели {DayWeek} рабочий");
}
}
else
{
   Console.WriteLine($"Нет такого дня недели");
}*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdDigit(int digit)
{
if(digit>=100)
{
while(digit>999)
{
digit=digit/10;
}
digit=digit%10;
Console.WriteLine($"Third digit of a given number {digit}");
void ThirdDigit(int digit)
{
    if(digit>=100)
    {
        while(digit>999)
        {
            digit=digit/10;
        }
        digit=digit%10;
        Console.WriteLine($"Third digit of a given number {digit}");
    }
    else
    {
        Console.WriteLine("There is no third number.");
    }
}
Console.WriteLine($"Enter the number");
int digit1=Convert.ToInt32(Console.ReadLine());
ThirdDigit(digit1);
{digit};
}
else
{
Console.WriteLine("There is no third number.");
}
}
Console.WriteLine($"Enter the number");
int digit1=Convert.ToInt32(Console.ReadLine());
ThirdDigit(digit1);
