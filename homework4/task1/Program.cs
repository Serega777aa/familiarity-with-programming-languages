Console.WriteLine("Введите число A");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int expon = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < expon; i++)
{
    result *= num;
}

Console.WriteLine(result);
