// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100,999);
Console.WriteLine(a);

int a1digit  = a / 100;
int a3digit = a %10;
Console.WriteLine(a1digit %10);
Console.WriteLine(a3digit);

Console.WriteLine($"{a1digit}{a3digit}");