// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ConsoleEnterData (string enter)   
{
    Console.WriteLine(enter);
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}


int ConclusionInerval(int Num, int Sum = 0)
{
    if (Num == 0)
    {
        return 0;
    }
    Sum = Num % 10 + ConclusionInerval (Num / 10);
    return Sum;
}



int Number = ConsoleEnterData ("введите число");
int Num = ConclusionInerval (Number);
Console.WriteLine(Num);