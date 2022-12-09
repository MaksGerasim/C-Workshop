// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


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

int DifferenceMinMaxNumber (int [] array)
{
    int Diff = 0;
    int MinNumber = array[0];
    int MaxNumber = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinNumber)
        {
            MinNumber = array[i];   
        }
        else if (array[i] > MaxNumber)
        {
            MaxNumber = array[i];
        }
    }
Console.WriteLine ($"минимальное значение = {MinNumber}");
Console.WriteLine ($"максимальное значение = {MaxNumber}");
    Diff = MaxNumber - MinNumber;
    return Diff;
}

const int SIZE = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 99;

int [] RandArray = RandomArray (SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join (",", RandArray));
int DiffMinMax = DifferenceMinMaxNumber (RandArray);
Console.WriteLine ($"Difference  = {DiffMinMax}");