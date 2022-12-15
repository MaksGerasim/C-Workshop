// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с 
//сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.WriteLine("введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number2 + number1 )
{
    Console.WriteLine("условие существования треугольника выполнено");
}

else
{
    Console.WriteLine("треугольник существовать не может");
}
