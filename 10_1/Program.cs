//  2. Даны два числа. 
// Показать большее и меньшее число

// 11. Дано число из отрезка [10, 99]. 
// Показать наибольшую цифру числа

// Console.WriteLine("Введите число от 10 до 99: ");
// int n = int.Parse(Console.ReadLine());

void Numbers (int a)
{
    if (a < 10 || a > 99)
    Console.WriteLine ("Введите число от 10 до 99");
    else
    {
        if (a % 10 > a / 10)
        Console.WriteLine($"{a % 10}");
        else Console.WriteLine ($"{a/10}");
    } 
}

Console.WriteLine("Введите число от 10 до 99: ");
int a = int.Parse(Console.ReadLine());
Numbers (a);