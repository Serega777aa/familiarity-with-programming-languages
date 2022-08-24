Console.WriteLine("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine("max = " + max);

