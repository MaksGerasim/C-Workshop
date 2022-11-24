// Напишите программу, которая на вход принимает число и выдает, является ли число четным 
//(делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите значение");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)

{
Console.WriteLine ("Число четное");
}

else
{
Console.WriteLine ("Число нечетное");
}
