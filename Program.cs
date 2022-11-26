// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool day_of_the_week(int day)
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
Console.WriteLine($"День недели {DayWeek} рабочий");
}
else
{
Console.WriteLine($"День недели {DayWeek} выходной");
}
}
else
{
   Console.WriteLine($"Нет такого дня недели");
}