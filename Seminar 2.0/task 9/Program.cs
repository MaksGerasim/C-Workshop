//случайное число из [10. 99] > наибольшая цифра сгенерированного числа


int number = new Random().Next(10, 100);
//генерация случайного значения new-тип данных? Random-генерация значения, 
//Next(10, 100) - интервал генерируемого числа 
//*значение (100) указывается на еденицу больше заданного значения
Console.WriteLine (number);
int digit2 = number % 10;
// поиск второго числа
int digit1 = number / 10;
// поиск первого числа

Console.WriteLine ($"первая цифра = {digit1}, вторая цифра = {digit2}");
//вывод значаний
if (digit1>digit2)
{
   Console.WriteLine (digit1); 
}
else
{
     Console.WriteLine (digit2); 
}