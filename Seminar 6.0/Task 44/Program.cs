// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

int [] ArrayFi = new int [number];
ArrayFi[0] = 0;
ArrayFi[1] = 1;

for (int i = 2; i < number; i++)
{
   ArrayFi[i] = ArrayFi[i-1] + ArrayFi[i-2];
}

Console.WriteLine(string.Join(",", ArrayFi));






