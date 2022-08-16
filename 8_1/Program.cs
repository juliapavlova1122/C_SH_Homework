// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;    
}


void SelectionSort(int[] arr)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
        for(int i=0; i<arr.GetLength(0); i++)
    {
        int minPosition = arr [i];
        for(int count = i+1; count <arr.Length; count++)
        {
            if(arr[count] < arr[minPosition]) minPosition = count;
        }

        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);




