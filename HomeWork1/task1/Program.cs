Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}    
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);