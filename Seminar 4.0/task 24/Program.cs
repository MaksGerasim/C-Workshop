// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

bool Validate (int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Sum1toA (int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
         sum += i;
    }
    return sum;
}

int GetNumber (string message)
{
    Console.WriteLine ("введите значение");
    return Convert.ToInt32 (Console.ReadLine ());
}

int number = GetNumber("");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int sum = Sum1toA(number);
    Console.WriteLine ($"Сумма чисел от 1 до {number} = {sum}");
}
else
{Console.WriteLine ("невозможно получить сумму от 1 до {number}");
}







// Console.WriteLine ("введите значение");

// int number = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine (number);