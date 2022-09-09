int [,] array = new int[,] {{1, 4, 7, 2},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4}};
double avgColumn;
for (int i = 0; i < array.GetLength(1); i++)
{
    int sumColumn = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sumColumn += array[j, i];
    }
    avgColumn = (double)sumColumn / array.GetLength(0);
    Console.Write(Math.Round(avgColumn, 1) + " ");

}


