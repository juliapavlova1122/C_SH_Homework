// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите {m} чисел: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите следующее число: ");
int n_1 = int.Parse(Console.ReadLine());

int i = 1;
while (i < m)
{
    Console.Write(i);
    i++;
}

// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11


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



void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round (new Random().NextDouble() * (10-1) + 1, 2);
            }
    return arr;
}

double[] arr_1 = MassNums(10);
Print(arr_1);
