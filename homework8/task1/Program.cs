int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] array = CreateArray(9, 2);


int minSumRow = 0;
int numberRow = 1;
for (int i = 0; i < array.GetLength(1); i++)
{
    minSumRow += array[0, i];
}


for (int i = 1; i < array.GetLength(0); i++)
{
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    if (sumRow < minSumRow)
    {
        minSumRow = sumRow;
        numberRow = i + 1;

    }
}
Console.WriteLine($"номер строки с наименьшей суммой элементов: {numberRow}");

