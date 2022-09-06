Console.Write("ВВедите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("ВВедите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("ВВедите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("ВВедите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = ( b2 - b1) / (k1 - k2);    

double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

if ((k1 == k2) && (b1 == b2))
{
    Console.Write("Прямые совпадают ");
}
else if (k1 == k2)
{
    Console.Write("Прямые параллельны ");
}
else
{
    Console.Write($"Точка пересечения прямых: {x}, {y} ");
}

