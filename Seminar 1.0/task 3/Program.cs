// Monday
// tuesday
// Wednesday
// Thursday
// friday
// Saturday
// Sunday

Console.WriteLine("введите день недели ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine("Monday ");
if (number == 2) Console.WriteLine("Tuesday ");
if (number == 3) Console.WriteLine("Wednesday ");
if (number == 4) Console.WriteLine("Thursday ");
if (number == 5) Console.WriteLine("Friday ");
if (number == 6) Console.WriteLine("Saturday ");
if (number == 7) Console.WriteLine("Sunday ");
else
{
   Console.WriteLine("Введите значение от 1 до 7 "); 
}


// if (number > 7) Console.WriteLine("Введите значение от 1 до 7 ");
// if (number < 1) Console.WriteLine("Введите значение от 1 до 7 ");
