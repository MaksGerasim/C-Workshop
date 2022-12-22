//  Задайте двумерный массив. Напишите программу, 
//  которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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


int[,] SortingNumbersRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int jNumSort = 0;
        while (jNumSort < matrix.GetLength(1))
        {
            int minn = matrix[i,jNumSort];
            int jmin = 0;
            int temp = 0;
            for (int j = jNumSort; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] <= minn)
                {
                    minn = matrix[i,j];
                    jmin = j;
                }
            }
            temp = matrix[i,jNumSort];
            matrix[i,jNumSort] = minn;
            matrix[i,jmin] = temp;
            jNumSort++;
        }
    }
    return matrix;
}



const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
Console.WriteLine("");
int [,] nummin = SortingNumbersRows (RandMatrix);
// int [,] NewMatrix = SortingNumbersRows (RandMatrix);
PrintMatrix(nummin);





