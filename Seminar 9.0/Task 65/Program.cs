// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ConsoleEnterData (string enter)   
{
    Console.WriteLine(enter);
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}


void ConclusionInerval(int NumMin, int NumMax)
{
        Console.Write($"{NumMin}, ");
        NumMin++;

    if (NumMin < NumMax+1)
    {
        ConclusionInerval(NumMin, NumMax);
    }
}

int Number = ConsoleEnterData ("введите первое число");
int Number2 = ConsoleEnterData ("введите второе число");

ConclusionInerval (Number, Number2);