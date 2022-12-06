// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int InputConsole (string message)
{
    Console.WriteLine ("введите значение");
    return Convert.ToInt32 (Console.ReadLine ());
}

int SumDigit (int A)
{
    int sum = 0;
    int digit2 = 0;
    for (; A > 0; A /= 10)
    {
         digit2 = A%10;
         sum = sum + digit2;
    }
    return sum;
}


int number = InputConsole ("");
int sumdigitNum = SumDigit (number);
Console.WriteLine (sumdigitNum);
