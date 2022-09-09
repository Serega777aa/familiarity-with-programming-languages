Console.WriteLine("Введите количество строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rand.Next(1, 20);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позиции элемента в двумерном массиве  ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a < 0 || a >= array.GetLength(0) ||
    b < 0 || b >= array.GetLength(1))
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine(array[a,b]);
}

