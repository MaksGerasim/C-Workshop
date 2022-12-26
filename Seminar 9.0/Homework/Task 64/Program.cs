// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ConsoleEnterData ()   
{
    Console.WriteLine("Введите значение");
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}

void NumberConclusion(int Num)
{
        Console.Write($"{Num}, ");

    if (Num > 1)
    {
        NumberConclusion(Num - 1);
    }
}


int Number = ConsoleEnterData ();
Console.WriteLine("");
NumberConclusion (Number);