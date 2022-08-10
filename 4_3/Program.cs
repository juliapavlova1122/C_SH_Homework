// Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран


int[] arr(int num)
{
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(0, 10);
    }
    return array;
}
arr(8);

void PrintArray (int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.WriteLine($"{array2[i]} ");
}
PrintArray(arr(8));