// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



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


(int, int) SumPositiveAndNegative (int [] array)
{
    int SumPositive = 0;
    int SumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
     if (array[i] > 0)
     {
        SumPositive += array[i];
     }
     else
     {
        SumNegative += array[i];
     }
    }
    return (SumPositive, SumNegative);
}

const int SIZE = 12;       // введенные константы прописываются ниже в шапке метода и передают введенные значения
const int lEFTRANGE = -9;
const int RIGHTRANGE = 9;

int [] arrey = RandomArray (SIZE, lEFTRANGE, RIGHTRANGE);
Console.WriteLine (string.Join (",", arrey));

(int SumP, int SumN) = SumPositiveAndNegative (arrey);
Console.WriteLine ($"положительные {SumP}, отрицательные {SumN}");