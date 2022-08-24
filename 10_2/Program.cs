// 13. Выяснить, кратно ли число заданному, 
// если нет, вывести остаток.

void Multiplicity (int a, int b)
{
    if (a % b == 0)
    Console.WriteLine ("It is ok");
    else 
    Console.WriteLine($"It is not ok, remainder is {a % b} ");
}

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Multiplicity (a, b);

