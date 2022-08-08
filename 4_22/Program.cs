// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Решение через string


double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;
    for (int i = 0; i < length; i++)
    {

        double m = char.GetNumericValue(n[i]);

        sum += m;
    }

    return sum;
}

int n = 452;

Console.WriteLine(DigitSum(n));