// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine ("введите число");
int number = Convert.ToInt32 (Console.ReadLine());
int count = 1;

if (number < 0)
{
    Console.WriteLine ("введите положительное значение");
}
else
while (count < number || count == number)
      {
       double square = Math.Pow((count),2);
       Console.WriteLine (square);
       count++;
      }