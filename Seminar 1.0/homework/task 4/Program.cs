// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите число a");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c");
int numberC = Convert.ToInt32(Console.ReadLine());

int MaxNumber;

if(numberA < numberB)
{
MaxNumber = numberB;
}

else
{
MaxNumber = numberA;
}

if(MaxNumber < numberC)
{
MaxNumber = numberC;
}

Console.Write("Максимальное число равно   ");
Console.WriteLine(MaxNumber);

