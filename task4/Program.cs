// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Write number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write number b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write number c: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.Write("max= ");
        Console.WriteLine(a);
    }
    else
    {
        Console.Write("max= ");
        Console.WriteLine(c);
    }    
}
else
{
      if (b > c)
    {
        Console.Write("max= ");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("max= ");
        Console.WriteLine(c);
    }    
}
