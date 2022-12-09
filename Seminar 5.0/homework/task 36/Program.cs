// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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


int AddOddNumber (int [] array)
{
    int AddOddNumber= 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1)
        {
            AddOddNumber += array[i];
            
        }
    }
    return AddOddNumber;
}

const int SIZE = 4;
const int LEFTRANGE = -99;
const int RIGHTRANGE = 99;

int [] RandArray = RandomArray (SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join (",", RandArray));
int AddOdd = AddOddNumber (RandArray);
Console.WriteLine ($"сумма значений нечетного индекса = {AddOdd}");