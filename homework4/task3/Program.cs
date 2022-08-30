int MultiplDigits(int number)
{
    int multipl = 1;
    int temp = number;
    while (number > 0)
    {
        temp = number % 10;
        if (temp != 0)
        {
            multipl *= temp;
            number /= 10;
        }
        else
        {
            number /= 10;
        }
    }
    return multipl;
}

int SumDigits(int number)
{
    int sum = 0;
    int temp = number;
    while (number > 0)
    {
        temp = number % 10;
        sum += temp;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int[] interesNums = new int[n];

int randNum = 0;

for (int i = 0; i < n; i++)
{
    
    while (interesNums[i] == 0)
    {
        randNum =  new Random().Next();
        if (MultiplDigits(randNum) % SumDigits(randNum) == 0)
        {
            interesNums[i] = randNum;
        }
    }
}
for (int index = 0; index < n; index++)
{
    Console.Write($"{interesNums[index]} ");
}

