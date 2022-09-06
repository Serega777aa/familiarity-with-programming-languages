Console.Write("ВВедите натуральное число ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
int count = 0;
for (int i = 0; i < m; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
        count++;
}
for (int i = 0; i < m; i++)
{
    Console.Write(arr[i] + " ");
}
 Console.Write($"-> {count} ");

    
