bool Contains (int[,] arr, int value)
{
    bool flag = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == value)
            {
                flag = true;
                break;
            }
        }
    }
    return flag;
}


int [,] arr = new int [3, 3];
Random rand = new Random();
int temp = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        bool flag = true;
        while (flag == true)
        {
            temp = rand.Next(10, 100);
            flag = Contains(arr, temp);
        }
        arr[i, j] = temp;
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}