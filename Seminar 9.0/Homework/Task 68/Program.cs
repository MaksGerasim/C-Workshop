// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int ConsoleEnterData (string enter)   
{
    Console.WriteLine(enter);
    int meaning = Convert.ToInt32(Console.ReadLine());
    return meaning;
}


int FAckerman (int m, int n)
{
    int A = 0;
    if (m == 0)
    {
        A = n+1;
    }
    else if (m > 0 && n == 0)
    {
        A = FAckerman (m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        A = FAckerman (m - 1, FAckerman (m, n - 1));
    }
    return A;
}


int m = ConsoleEnterData ("введите пчисло m");
int n = ConsoleEnterData ("введите число n");

int A = FAckerman (m, n);
Console.WriteLine(A);