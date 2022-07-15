// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
 
Console.WriteLine("Write a three-digit number: ");
int n = int.Parse(Console.ReadLine());

int n2digit  = n / 10;

Console.WriteLine(n2digit %10);
