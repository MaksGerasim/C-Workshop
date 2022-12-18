// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.


int[] RandomArray(int size, int leftRange, int rightRange) // создание вводных переменных метода
{
    int[] array = new int[size]; 
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


int[] CopyArray (int[]array)
{
int [] NewArray = new int[array.Length];
int i = 0;
while (i < array.Length)
{
    NewArray[i] = array[i];
    i++;
}
return NewArray;
}


const int SIZE = 5;       
const int lEFTRANGE = 0;
const int RIGHTRANGE = 150;

int [] arr = RandomArray(SIZE, lEFTRANGE,RIGHTRANGE);
int [] New = CopyArray (arr);

Console.WriteLine(string.Join(",", arr));
Console.WriteLine();
Console.WriteLine(string.Join(",", New));
