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
/*void ThirdDigit(int digit)
{
    if(digit>=100)
    {
        while(digit>999)
        {
            digit=digit/10;
        }
        digit=digit%10;
        Console.WriteLine($"Третья цифра заданного числа {digit}");
    }
    else
    {
        Console.WriteLine("Нет третьей цифры в заданном числе.");
    }
}
Console.WriteLine($"Введите число");
int digit1=Convert.ToInt32(Console.ReadLine());
ThirdDigit(digit1);*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int digit2(int number)
{
    int chislo = number%100;
    chislo=chislo/10;
    return chislo;
}
Console.WriteLine($"Введите техзначное число");
int number3=Convert.ToInt32(Console.ReadLine());
int numeric = digit2(number3);
Console.WriteLine($"Вторая цифра в числе {number3} это {numeric}");*/
