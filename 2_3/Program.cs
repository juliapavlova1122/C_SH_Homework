// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

if (n < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
    while (n > 999)
    n=n/10;
    Console.WriteLine(n%10);
    }    


