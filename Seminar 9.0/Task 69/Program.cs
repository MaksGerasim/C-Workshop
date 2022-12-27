// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ConsoleEnterData (string enter)   
{
    Console.WriteLine(enter);
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}


int ConclusionInerval(int Num, int Num2)
{
    if (Num2 == 0)
    {
        return 1;
    }
    Num *= ConclusionInerval(Num, Num2 - 1);
    return Num;
}



int Number = ConsoleEnterData ("введите первое число");
int Number2 = ConsoleEnterData ("введите второе число");
int Num = ConclusionInerval (Number, Number2);
Console.WriteLine(Num);