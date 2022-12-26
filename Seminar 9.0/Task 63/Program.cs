//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int ConsoleEnterData ()   
{
    Console.WriteLine("Введите значение");
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}


void NumberConclusion(int Num, int Count = 1)
{
        Console.Write($"{Count}, ");
        Count++;

    if (Count < Num + 1)
    {
        NumberConclusion(Num, Count);
    }
}

int Number = ConsoleEnterData ();
Console.WriteLine("");
NumberConclusion (Number);