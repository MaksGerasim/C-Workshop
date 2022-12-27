// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2) 
{
    Console.WriteLine("Значения равны"); Console.Write(number1); Console.Write(" = "); Console.Write(number2);
}    
else
{
  if (number1 > number2)
  {
    Console.Write("Min = "); Console.WriteLine(number2); Console.Write("Max = "); Console.WriteLine(number1);
  } 
  else 
  {
    Console.Write("Min = "); Console.WriteLine(number1); Console.Write("Max = "); Console.WriteLine(number2);
  }
}

