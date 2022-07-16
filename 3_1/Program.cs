// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Write a 5 digit number: ");
int a = int.Parse(Console.ReadLine());

if (a > 99999 || a<10000) 
    {
    Console.WriteLine("Please check your number and write 5 digit number: ");
    }
else
    {
    int a1digit = a / 10000;
    Console.WriteLine(a1digit);
    int a2digit = (a / 1000) %10;
    int a3digit = (a / 100) %10;
    int a4digit = (a / 10) %10;
    int a5digit = a %10;

    if (a1digit == a5digit && a2digit == a4digit)
       {
        Console.WriteLine("It's a numeric palindrome");
       } 
    else
        {
            Console.WriteLine("It is't a numeric palindrome");
        }
    }
    