// See https://aka.ms/new-console-template for more information
using System;

int year;
Console.WriteLine("enter the year:");
year = int.Parse(Console.ReadLine());
if (year % 4 ==0 && year % 400 == 0)
{
    Console.WriteLine(year + "it is leap year");
}
else
{
    Console.WriteLine(year + "it is not leap year");
}
