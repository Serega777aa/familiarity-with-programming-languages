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

for (int i = 0; i < n; i++)
{
    numbers[i] = rand.Next(1, 100);
}
int minNumber = numbers[0];
int maxNumber = numbers[0];

for (int i = 1; i < n; i++)
{
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }
}
int diffMaxMin = maxNumber - minNumber;
PrintArray(numbers);
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + diffMaxMin);
