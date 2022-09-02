void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
Random rand = new Random();
int countEven = 0;

for (int i = 0; i < n; i++)
{
    numbers[i] = rand.Next(100, 1000);
    if (numbers[i] % 2 == 0)
    {
        countEven++;
    }
}
PrintArray(numbers);
Console.WriteLine($"в массиве {countEven} четных елемента");