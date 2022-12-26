// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ConsoleEnterData (string enter)   
{
    Console.WriteLine(enter);
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}


int AddElementNumber(int NumMin, int NumMax)
{
    int Add = NumMax;

    if (NumMax < NumMin)
    {
        return 0;
    }
    Add = Add + AddElementNumber (NumMin, NumMax - 1);
    return Add;
}


int Number = ConsoleEnterData ("введите первое число");
int Number2 = ConsoleEnterData ("введите второе число");

int AddEl = AddElementNumber (Number, Number2);
Console.WriteLine(AddEl);