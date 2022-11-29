// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine ("введите число");
int number = Convert.ToInt32 (Console.ReadLine ());

int statusnumber = number/1000;

if (number < 100)
{
  Console.WriteLine ("третьей цифры нет ");  
}
else
{
    while (statusnumber > 0)
    {
        number = (number - number % 10) / 10;
        statusnumber = number/1000;
    }
     int digit3 = number % 10;
     Console.WriteLine (digit3);
}

