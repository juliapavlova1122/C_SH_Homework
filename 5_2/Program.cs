// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 89, 6] -> 0

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
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}

int Sum(int[] arr)
{   
    int n = arr[0];
    for (int i = 2; i < arr.Length; i+=2)
    {
        n += arr[i];            
    }
    
    return n;    
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(Sum(arr_1));




