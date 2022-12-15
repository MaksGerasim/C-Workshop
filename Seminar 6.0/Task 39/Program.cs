// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем 
// и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] RandomArray(int size, int leftRange, int rightRange) // создание вводных переменных метода
{
    int[] array = new int[size]; // создаем массив, 'size' передает данные полученные на вход для метода
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void ReversArray (int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array [i];
        array[i] = array[array.Length -i - 1];
        array[array.Length -i - 1] = temp;
    }

}


const int SIZE = 5;       
const int lEFTRANGE = 0;
const int RIGHTRANGE = 150;

int [] arr = RandomArray(SIZE, lEFTRANGE,RIGHTRANGE);
Console.WriteLine(string.Join(",", arr));
ReversArray (arr);
Console.WriteLine();
Console.WriteLine(string.Join(",", arr));