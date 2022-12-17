//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1,
// y = k2 * x + b2;

//  k1 * x + b1 = k2 * x + b2

//  k1 * x - k2 * x = b2 - b1

// double x = (b2 - b1)/(k1 - k2);
// double y = k1 * (b2 - b1)/(k1 - k2) + b1;


void thePointOfTwoStraightLines ()
{
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2)
{
Console.WriteLine("прямые параллельны");
}
else
{
x = (b2 - b1)/(k1 - k2);
y = k1 * (b2 - b1)/(k1 - k2) + b1;
Console.WriteLine($"P = ({x};{y})");
}
}



thePointOfTwoStraightLines ();