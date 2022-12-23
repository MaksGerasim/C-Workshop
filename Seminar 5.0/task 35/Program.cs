// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний 
//и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] RandomArray(int size, int leftRange, int rightRange) // создание случайного массива
{
    int[] array = new int[size]; // создаем массив, 'size' передает данные полученные на вход для метода
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int CountMeaningArray (int [] array, int maxInterval, int minInerval)   // количество значений в интервале от и до
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > minInerval-1 && array[i] < maxInterval+1)
        {
            Count++;
        }
    }
    return Count;
}


int[] MultiplicationNumberArray(int[] array) //произведение зеркальных элементов массива
{
    int iStart = 0;
    int iEnd = array.Length-1;
    int [] NewArray = new int [(array.Length + 1)/2]; //либо + array.Length % 2, проверка на четность дает 0 и 1
    
    for (; iStart < array.Length/2; iStart++)
    {
       NewArray[iStart] = array[iStart] * array[iEnd];
       iEnd = iEnd-1;
    }
    if (iEnd == iStart)
    NewArray[iStart] = array[iStart];

   
    return NewArray;
}






const int SIZE = 8;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 11;

const int MININTERVAL = 10;
const int MAXINTERVAL = 99;

int [] RandArray = RandomArray (SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join (",", RandArray));
int CountMeaning = CountMeaningArray (RandArray, MAXINTERVAL, MININTERVAL);
Console.WriteLine($"количество значений в заданном интервале =  {CountMeaning}");
int [] NewArray = MultiplicationNumberArray(RandArray);
Console.WriteLine(string.Join (",", NewArray));



