// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine ("введите пятизначное число");
int number = Convert.ToInt32 (Console.ReadLine());

int digit1 = number / 10000;
int digit2 = number % 10;
int digit21 = (number - digit1*10000) / 1000;
int digit22 = ((number - digit2) / 10) %10;


if (number/100000 > 0 || number < 10000)
{
    Console.WriteLine ("ERROR введите пятизначное число");
}
else
{
    if (digit1 == digit2 && digit21 == digit22)
    {
    Console.WriteLine ("да");
    }
    else
    {
    Console.WriteLine ("нет");
    }
}








// while (Count < size)
// {
//     numberturn = (numberturn - digit2) / 10 + (digit2 * 10000);
//     numberturn2 = ();
//     Count = Count+1;
// }

// if (numberturn == number)
// {
//     Console.WriteLine ("да");
// }

// else
// {
//     Console.WriteLine ("нет");
// }

