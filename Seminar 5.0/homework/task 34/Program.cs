// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandomArray(int size, int leftRange, int rightRange) // создание случайного массива
{
    int[] array = new int[size]; 
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


int CountPositiveNumber (int [] array)
{
    int CountPosNum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            CountPosNum++;
        }
    }
    return CountPosNum;
}

const int SIZE = 5;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 999;

int [] RandArray = RandomArray (SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join (",", RandArray));
int CountPositive = CountPositiveNumber (RandArray);
Console.WriteLine ($"количество четных значений = {CountPositive}");