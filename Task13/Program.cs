Random random = new Random();
int number = random.Next(10, 10001);
Console.WriteLine($"Random number = {number}");
var str = number.ToString();
if (str.Length < 3)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(str[2]);
