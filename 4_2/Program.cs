// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
while (a > 0) 
{
    sum += a % 10;
    a /= 10;
}

Console.WriteLine (sum);


int sumnum(int num)
{
    int n_sum = 0;

    for (int i = num; num != 0; num /= 10)
    n_sum +=num%10;
    return n_sum;
}

// Console.WriteLine ...