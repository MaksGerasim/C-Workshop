// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1



int[,] RandomTwoDimensionalArray(int rowsCount, int colunsCount, int leftRange, int rightRange)
{
    int[,] array = new int[rowsCount, colunsCount];
     
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return array;
}


// int GetNumber (string Message)
// {
//     Console.WriteLine(Message);
//     return Convert.ToInt32(Console.ReadLine());
// }

void PrintMatrix (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr [i,j] + " ");     
        }
        Console.WriteLine();
    }
}





const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 0;
const int RIGHTRANGE = 150;

int [,] NewArray = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(NewArray);
