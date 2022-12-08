// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".


int [] RandomArray (int size, int leftRange, int rightRange) // создание случайного массива
{
int [] array = new int[size]; // создаем массив, 'size' передает данные полученные на вход для метода
Random rand = new Random ();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1);
}
return array;
}



int [] ArrayRreplacementNumbers (int [] array) // замена отрицательных знаков чисел массива на положительные
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] < 0)    
array[i] = array[i] * -1;
}
return array;
}

string SearchNumberInArray (int [] array, int number)  // поиск наличия заданного значения в массиве
{
string Status = ("нет");    
for (int i = 0; i < array.Length; i++)
{
if (array[i] == number)
{ 
Status = ("Да");
}   
}
return Status;
}



const int SIZE = 4;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
Console.WriteLine ("введите число для поиска в массиве");
int NumberInArray = Convert.ToInt32 (Console.ReadLine ());

int [] array = RandomArray (SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join (",", array));

int [] NewArray = ArrayRreplacementNumbers (array);
Console.WriteLine(string.Join (",", array));

string NumberStatus = SearchNumberInArray (NewArray, NumberInArray);
Console.WriteLine(NumberStatus );
