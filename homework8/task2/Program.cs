int [,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int [,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int tempSum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                tempSum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = tempSum;
        }
    }
return resultMatrix;
}   

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

int [,] array1 = new int[,] {{2, 4},
                             {3, 2},};

 int [,] array2 = new int[,] {{3, 4},
                              {3, 3},};

int[,] arr = MultiplyMatrix(array1, array2);
PrintArray(arr);



