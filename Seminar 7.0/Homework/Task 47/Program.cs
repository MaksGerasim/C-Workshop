//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9


double [,] RandomTwoDimensionalArray (int rowsCount, int columnsCount) //double leftRange, double rightRange
{
    double [,] array = new double[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * (10+10) - 10;
        }
    }
    return array;
}

void PrintMatrix (double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr [i,j]:f2}, ");     
        }
        Console.WriteLine();
    }
}

const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 4;


double [,] NewArray = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT);
PrintMatrix (NewArray);




