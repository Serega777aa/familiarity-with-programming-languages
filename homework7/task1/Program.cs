Console.WriteLine("Введите количество строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
