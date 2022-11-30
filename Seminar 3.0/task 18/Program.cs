// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine ("введите четверти");
int quarter = Convert.ToInt32 (Console.ReadLine());

if (quarter == 1)
{
     Console.Write("(numX > 0 && numY > 0)");
}

else if (quarter == 2)
{
    Console.Write("numX < 0 && numY > 0");
}
else if (quarter == 3)
{
    Console.Write("numX < 0 && numY < 0");
}
else if (quarter == 4)
{
    Console.Write("numX > 0 && numY < 0");
}
else  
{
Console.Write("заданное значение неверное");
}

