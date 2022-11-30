

Console.WriteLine ("введите x");
int numX = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("введите y");
int numY = Convert.ToInt32 (Console.ReadLine());

if (numX > 0 && numY > 0)
{
    Console.Write("точка в первой четверти");
}
else if (numX < 0 && numY > 0)
{
    Console.Write("точка во второй четверти");
}
else if (numX < 0 && numY < 0)
{
    Console.Write("точка в третьей четверти");
}
else if (numX > 0 && numY < 0)
{
    Console.Write("точка в четвертой четверти");
}
else
{
    Console.Write("заданное значение неверное");
}
