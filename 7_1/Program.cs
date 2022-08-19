// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Print(double[,] arr)
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
double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
           // arr [i, j] = Math.Round(new Random().NextDouble() * ((100)- (-100) +  (-100)), 2);
           arr [i, j] = Math.Round(new Random().NextDouble() * (100 - 200) + 50, 2);         
        }        
    }
    return arr;    
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
double[,] arr_1 = MassNums(row, column, -100, 100);
Print(arr_1);

