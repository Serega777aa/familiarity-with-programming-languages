void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillSpiralArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int number = 1;

    for (int i = 0; i < n * m; i++)
    {
        for (int j = i; j < m - i; j++)
        {
            array[i, j] = number;
            number++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            array[k, m - 1 - i] = number;
            number++;
        }
        for (int j = m - i - 2; j >= i; j--)
        {
            array[n - 1 - i, j] = number;
            number++;
        }
        for (int k = n - 2 - i; k > i; k--)
        {
            array[k, i] = number;
            number++;
        }
    }
}

int[,] arr = new int[4, 4];
FillSpiralArray(arr);
PrintArray(arr);
