Console.Write("ВВедите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    arr[i] = rand.Next(1, 21);
}
int sum = 0;
for (int i = 0; i < n / 2; i++)
{
    sum += arr[i] * arr[n - 1 - i];
}
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine($"-> {sum}");

