// Определить номер четверти плоскости, в которой 
// находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

string Quarter (int x, int y) 
{
    string flag = " ";
    if ( x != 0 && y != 0)
    {
        if (x > 0 && y > 0)
            flag = "first quarter";
        else if (x > 0 && y < 0)
            flag = "second quarter";
        else if (x < 0 && y < 0)
            flag = "third quarter"; 
        else if (x < 0 && y > 0)
            flag = "fourth quarter";
    }
    else 
    flag = "Coordinates don't belong any quarter";

    return flag;
}

Console.WriteLine("Enter x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine (Quarter (x, y));