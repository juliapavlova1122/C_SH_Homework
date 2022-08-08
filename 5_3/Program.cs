// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементом массива.
// [3 7 22 2 78] -> 76

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

int MinimumSearch(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
    } 
    return min;  
}
int MaximumSearch(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
    } 
    return max;  
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(MinimumSearch(arr_1));
Console.WriteLine(MaximumSearch(arr_1));
int d = MaximumSearch(arr_1) - MinimumSearch(arr_1);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:  {d}");
