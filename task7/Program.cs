// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

int i = 2;

while (i <= n)
{
    Console.WriteLine(i);
    i+=2;
}

