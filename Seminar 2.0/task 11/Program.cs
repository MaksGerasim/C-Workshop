// убрать вторую цифру из трехзначного числа

int number = new Random().Next(100, 1000);

Console.WriteLine (number);
int digit1 = number / 100;
int digit2 = number % 10;

// Console.WriteLine (digit1);
// Console.WriteLine (digit2);
//Console.WriteLine ($"{digit1}{digit2}");

int digit3 = digit1*10 + digit2;
Console.WriteLine (digit3);