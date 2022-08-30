Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int sumDigit = 0;
int tempNum = num;
int tempDigit = 0;

while (tempNum > 0)
{
    tempDigit =  tempNum % 10;
    if (tempDigit != 0)
    {
        if (num % tempDigit == 0)
        {
            sumDigit += tempDigit;
        }
    }
    tempNum /= 10;
}
Console.WriteLine(sumDigit);
