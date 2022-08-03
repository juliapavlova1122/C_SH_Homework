// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Nums (int a, int b)

{
    int exponentiation = a;
    for(int i = 1; i<b; i++)
    exponentiation = exponentiation * a;
    return exponentiation;
}

Console.WriteLine(Nums(3, 5));

