//  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
int num7 = 7;
int num23 = 23;

if (number1 % num7 == 0 && number1 % num23 == 0)
{
   Console.WriteLine("кратно"); 
}
else
{
    Console.WriteLine("не кратно");    
}