// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1
//int number = new Random().Next(100, 1000);

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int digit2 = number % 10;
int digit1 = number/100;

int digit3 = (number - digit1*100 - digit2)/10;

Console.WriteLine (digit3);


