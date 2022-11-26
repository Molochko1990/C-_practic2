Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine($"Random number = {number}");
int a = number / 10;
Console.WriteLine(a);
int b = a % 10;
Console.WriteLine(b);
