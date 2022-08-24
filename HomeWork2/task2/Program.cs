int randomNum = new Random().Next(1, 65537);

Console.WriteLine(randomNum);

if (randomNum >= 10000)
{
    Console.WriteLine(randomNum / 100 % 10);
}
if (randomNum >= 1000 && randomNum < 10000)
{
    Console.WriteLine(randomNum / 10 % 10);
}
if (randomNum >= 100 && randomNum <1000)
{
    Console.WriteLine(randomNum % 10);
}
if (randomNum < 100)
{
    Console.WriteLine("третьей цифры нет");
}
