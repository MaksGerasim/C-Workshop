// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
       double cub = Math.Pow((count),3);
       Console.WriteLine (cub);
       count++;
      }