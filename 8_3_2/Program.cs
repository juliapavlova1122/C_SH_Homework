// 3. Задайте две матрицы. Напишите программу,
//    которая будет находить произведение двух матриц.

//    https://blog.fenix.help/podgotovka-k-testam-yekzamenam-zachetam/pravilo-umnozheniya-matrits-primery-s-resheniyem
//    https://lfirmal.com/matritsyi-chastnyie-vidyi-matrits/#%D0%A3%D0%BC%D0%BD%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] MatrixProduct(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (column_size != arr_second.GetLength(0)) return pr_matrix;
    else if (column_size == arr_second.GetLength(0))
        pr_matrix = new int[row_size, row_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < row_size; j++)
        {
            for (int p = 0; p < column_size; p++)
                pr_matrix[i, j] += arr_first[i, p] * arr_second[p, j];
        }
    }
    return pr_matrix;
}


Console.Write("Enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 1: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number of rows 2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1, 0, 5);
Print(arr_1);
int[,] arr_2 = MassNums(row_2, column_2, 0, 5);
Print(arr_2);

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);


