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
int sumEven = 0;

for (int i = 0; i < n; i++)
{
    numbers[i] = rand.Next(10, 100);
    if (i % 2 != 0)
    {
        if (numbers[i] % 2 == 0)
        {
            sumEven += numbers[i];
        }
    }
}
PrintArray(numbers);
Console.WriteLine($"сумма четных елементов, стоящих на нечетных позициях равна {sumEven}");