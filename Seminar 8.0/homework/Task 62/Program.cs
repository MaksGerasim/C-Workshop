// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] RandomSpiralArray(int rowsCount, int colunsCount, int leftRange, int rightRange)
{
    
    int[,] array = new int[rowsCount, colunsCount]; 

    int AdjLenght0 = array.GetLength(0);
    int AdjLenght1 = array.GetLength(1);
    int NumSize = 1;
    int RightI = 0; 
    int RightJ = 0;
    int DownI = 0;
    int DownJ = array.GetLength(0)-1;
    int LeftI = array.GetLength(1)-1;
    int LeftJ = array.GetLength(1)-1;
    int UpI = 2;
    int UpJ = 0;
    int count = 1;
while (count != 0)
{
    int RightStop = RightI+1;
    for (; RightI < RightStop; RightI++)
    {
        for (; RightJ < array.GetLength(0)-1; RightJ++)
        {
            array[RightI, RightJ] = NumSize++;
        }
    }
    
    int DownStop = DownJ+1; 
    for (; DownJ < DownStop; DownJ++)
    {
        for (; DownI < array.GetLength(1)-1; DownI++)
        {
            array[DownI, DownJ] = NumSize++;
        }
    }

    int LeftStop = LeftI-1;
    for (; LeftI > LeftStop; LeftI--)
    {
        for (; LeftJ > 0; LeftJ--)
        {
            array[LeftI, LeftJ] = NumSize++;
        }
    }

    int UpStop = UpJ-1;
    for (; UpJ > UpStop; UpJ--)
    {
        for (; UpI > 0; UpI--)
        {
            array[UpI,UpJ] = NumSize++;
        }
    }

    count--;
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


const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 3;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,] SpiralArray = RandomSpiralArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(SpiralArray);
