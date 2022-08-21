// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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

int [] MinRowSum (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int [] RowSum = new int [row_size];

    for (int i = 0; i < row_size; i++)
    {
        int sum = 0;
        for (int j = 0; j < column_size; j++)
        {
            sum = sum + arr [i, j];
            RowSum[i] = sum;
            
        }
    }
    return RowSum;
}

void RowString (int [] arr)
{
    int PosMin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr [PosMin])
        PosMin = i;
    }
    Console.WriteLine ($"Строка с наименьшей суммой элементов {PosMin+1} ");
}

void NewArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write ($"{arr[i]} ");
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 100);
Print(arr_1);

int [] arr2 = MinRowSum(arr_1);
Console.WriteLine("Суммы строк");
NewArray(arr2);
Console.WriteLine();

RowString(arr2);









