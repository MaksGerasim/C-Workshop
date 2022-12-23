// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
Console.WriteLine("кратно!");    
}
else
{
Console.WriteLine($"не кратно! остаток = {number1 % number2}");    
}
