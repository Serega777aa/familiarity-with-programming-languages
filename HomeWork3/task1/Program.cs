int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int pal = 0;

while (temp > 0)
{
    pal = pal * 10 + temp % 10;
    temp /= 10;
}
if (num == pal)
{
    Console.WriteLine("Палиндром");
}
else 
{
     Console.WriteLine("Не является палиндромом");
}


