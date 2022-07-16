// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter a day number: ");
int a = int.Parse(Console.ReadLine());

if (a > 7 || a<1) 
    {
    Console.WriteLine("Choose number from 1 to 7");
    }
else
    {
    if (a >= 1 && a <= 5)
        {
        Console.WriteLine("Working day");
        }
    if (a >= 6 )
        {
        Console.WriteLine("Day off");
        }
    }
