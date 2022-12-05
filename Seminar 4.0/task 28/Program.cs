// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int GetNumber (string message)
{
    Console.WriteLine ("введите значение");
    return Convert.ToInt32 (Console.ReadLine ());
}


// int multnum1 (int A)
// {
//     int multnum = 1;
//     int count = 1;
// while (count <= A)
// {
//     multnum = multnum * count;
//     count++;
// }
//    return multnum;
// }

int multnum2 (int A)
{
    int multnu = 1;
    for (int i = 1; i <= A; i++)
    {
         multnu = multnu * i;
    }
    return multnu;
}


int number = GetNumber ("");
int finishmultnum = multnum2 (number);
Console.WriteLine (finishmultnum);








