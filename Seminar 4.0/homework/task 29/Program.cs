// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем






int[] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
Console.WriteLine ("введите значение ячейки массива");    
array [i] = Convert.ToInt32 (Console.ReadLine());
}
Console.WriteLine (string.Join(",", array));