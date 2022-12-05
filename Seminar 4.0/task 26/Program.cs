// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int countfigure1 (int number)
{
   int count = 0;
while (number > 0)  
    {
    number = number / 10;
    count++;
    }
    return count;
}

int GetNumber (string message)
{
    Console.WriteLine ("введите значение");
    return Convert.ToInt32 (Console.ReadLine ());
}


int number = GetNumber ("");
int count = countfigure1 (number);
Console.WriteLine ($"количество цифр = {count}");