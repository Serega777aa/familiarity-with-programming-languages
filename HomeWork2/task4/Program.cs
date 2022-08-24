int randomNum = new Random().Next(1, 1000001);

if (randomNum % 7 == 0 && randomNum % 23 == 0)
{
    Console.WriteLine($"число {randomNum}  кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine($"число {randomNum}  не кратно одновременно 7 и 23");
}
