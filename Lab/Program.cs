



int [] RandomArray (int size, int leftRange, int rightRange) // создание вводных переменных метода
{
int [] array = new int[size]; // создаем массив, 'size' передает данные полученные на вход для метода
Random rand = new Random ();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1);
}
return array;
}

int[] SortingArray(int[] array)
{
    int iNumSort = 0;
    while (iNumSort < array.Length)
    {
    int minn = array[iNumSort];
    int imin = 0;
    int temp = 0;
    for (int i = iNumSort; i < array.Length; i++)
    {
        if (array[i] <= minn)
        {
            minn = array[i];
            imin = i;
        }
    }
    temp = array[iNumSort];
    array[iNumSort] = minn;
    array[imin] = temp;
    iNumSort++;
    }
    return array;
}







const int SIZE = 5;       
const int lEFTRANGE = 0;
const int RIGHTRANGE = 9;

int [] arrey = RandomArray (SIZE, lEFTRANGE, RIGHTRANGE);
Console.WriteLine (string.Join (", ",  arrey));
int [] Newarrey = SortingArray (arrey);
Console.WriteLine (string.Join (", ",  Newarrey));