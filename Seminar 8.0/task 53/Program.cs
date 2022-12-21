// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


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



int [,] ReplaisementRows (int [,] matrix)
{

    int iFirst = 0;
    int iLast = matrix.GetLength(0) - 1;
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         temp = matrix[iLast,j];
         matrix[iLast,j] = matrix[iFirst,j];
         matrix[iFirst,j] = temp;
    }
    return matrix;
}





const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;


int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
Console.WriteLine();
int [,] ReplaiMatr = ReplaisementRows (RandMatrix);
PrintMatrix(ReplaiMatr);



   











