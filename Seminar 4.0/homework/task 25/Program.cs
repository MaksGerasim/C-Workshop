// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!



Console.WriteLine ("введите значение A -(число)");
int A = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("введите значение B -(степень)");
int B = Convert.ToInt32 (Console.ReadLine ());



double multia = A;

if (B > 0 )
{
for (int i = 1; i < B; i++)
{
multia = multia * A;
}
}

else if (B < 0)
{
for (int i = -1; i > B; i--)
{
multia = multia * A;
}
multia = 1 / multia;
}

else if (B == 0 && A != 0)
{
multia = 1;
}

else
{
Console.Write ("неопределенность = ");
}


Console.WriteLine (multia);
