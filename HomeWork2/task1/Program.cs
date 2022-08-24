int randomNum = new Random().Next(100, 1000);

Console.WriteLine(randomNum);

int secondDigit = randomNum / 10 % 10;

Console.WriteLine(secondDigit);
