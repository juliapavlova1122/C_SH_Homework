// Задача 4 c семинара: Напишите программу, которая будет создавать
// копию заданного дробного массива с помощью поэлементного копирования. 


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
        arr[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
    }
    return arr;
}

double[] MassCopy(double[] arr)
{
    double [] new_arr = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        new_arr [i] = arr[i];
    }

    return new_arr;
}

double[] arr_1 = MassNums(10);
Print(arr_1);
double[] arr_2 = MassCopy(arr_1);
Print(arr_2);

