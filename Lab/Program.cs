

// int [] RandomArray (int size, int leftRange, int rightRange) // создание вводных переменных метода
// {
// int [] array = new int[size]; // создаем массив, 'size' передает данные полученные на вход для метода
// Random rand = new Random ();
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rand.Next(leftRange, rightRange + 1);
// }
// return array;
// }

// int[] SortingArray(int[] array)
// {
//     int iNumSort = 0;
//     while (iNumSort < array.Length)
//     {
//     int minn = array[iNumSort];
//     int imin = 0;
//     int temp = 0;
//     for (int i = iNumSort; i < array.Length; i++)
//     {
//         if (array[i] <= minn)
//         {
//             minn = array[i];
//             imin = i;
//         }
//     }
//     temp = array[iNumSort];
//     array[iNumSort] = minn;
//     array[imin] = temp;
//     iNumSort++;
//     }
//     return array;
// }

int[,] TwoDimensionalArray(int rowsCount, int colunsCount)
{
    int[,] array = new int[rowsCount, colunsCount];
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



int [,] RightRows (int [,] matr, int i, int j, int LengthI, int Lengthj)
{
    int NumCell;
    int RightStop = i+1;
        int maxNum = matr[0,0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
      for (int b = 0; b < matr.GetLength(1); b++)
      {
        if (matr[a,b] > maxNum)
        maxNum = matr[a,b];
      }  
    }
    for (; i < RightStop; i++)
    {
        NumCell = maxNum+1;
        for (; j < Lengthj; j++)
        {
            matr[i, j] = NumCell++;
        }
    }
    return matr;
}


int [,] DownRows (int [,] matr, int i, int j, int LengthI, int Lengthj)
{
    int NumCell;
    int DownStop = j+1;
    int maxNum = matr[0,0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
      for (int b = 0; b < matr.GetLength(1); b++)
      {
        if (matr[a,b] > maxNum)
        maxNum = matr[a,b];
      }  
    } 
    for (; j < DownStop; j++)
    {
        NumCell = maxNum+1;
        for (; i < LengthI; i++)
        {
            matr[i, j] = NumCell++;
        }
    }
    return matr;
}


int [,] LeftRows (int [,] matr, int i, int j, int LengthI, int Lengthj)
{
    int NumCell;
    int LeftStop = i-1;
        int maxNum = matr[0,0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
      for (int b = 0; b < matr.GetLength(1); b++)
      {
        if (matr[a,b] > maxNum)
        maxNum = matr[a,b];
      }  
    }
    for (; i > LeftStop; i--)
    {
        NumCell = maxNum+1;
        for (; j > Lengthj; j--)
        {
            matr[i, j] = NumCell++;
        }
    }
    return matr;
}


int [,] UpRows (int [,] matr, int i, int j, int LengthI, int Lengthj)
{
    int NumCell;
    int UpStop = j-1;
        int maxNum = matr[0,0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
      for (int b = 0; b < matr.GetLength(1); b++)
      {
        if (matr[a,b] > maxNum)
        maxNum = matr[a,b];
      }  
    }
    for (; j > UpStop; j--)
    {
        NumCell = maxNum+1;
        for (; i > LengthI; i--)
        {
            matr[i, j] = NumCell++;
        }
    }
    return matr;
}

int StatusExit (int [,] RandMatrix)
{
    int status;
if (RandMatrix.GetLength(0) <= RandMatrix.GetLength(0))
{
    status = RandMatrix.GetLength(1)/2;
}
else
{
    status = RandMatrix.GetLength(0)/2;
}
return status;
}

const int ROWSCOUNT = 5;
const int COLUNSCOUNT = 5;       

int [,] RandMatrix = TwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT);
PrintMatrix(RandMatrix);
Console.WriteLine("");

int count = 0;
int index = 0;
int status = StatusExit (RandMatrix);

while (count < status)
{
int RightI = 0 + index;
int RightJ = 0 + index;
int LengthI = RandMatrix.GetLength(0)-(1+index); // = строки
int Lengthj = RandMatrix.GetLength(1)-(1+index); // ||| колонки
int [,] ArrRight= RightRows (RandMatrix, RightI, RightJ, LengthI, Lengthj);
PrintMatrix(ArrRight);
Console.WriteLine("");

int DownI = 0 + index;
int DownJ = RandMatrix.GetLength(1)-(1+index);
LengthI = RandMatrix.GetLength(0)-(1+index); // = строки
Lengthj = RandMatrix.GetLength(1)-(1+index); // ||| колонки 
int [,] ArrDown= DownRows (ArrRight, DownI, DownJ, LengthI, Lengthj);
PrintMatrix(ArrRight);
Console.WriteLine("");

int LeftI = RandMatrix.GetLength(0)-(1+index);
int LeftJ = RandMatrix.GetLength(1)-(1+index);
Lengthj = 0 + index; // ||| колонки
int [,] ArrLift= LeftRows (ArrDown, LeftI, LeftJ, LengthI, Lengthj);
PrintMatrix(ArrRight);
Console.WriteLine("");

int UpI = RandMatrix.GetLength(0)-(1+index);
int UpJ = 0 + index;
LengthI = 0 + index; // = строки
int [,] ArrUp= UpRows (ArrLift, UpI, UpJ, LengthI, Lengthj);
PrintMatrix(ArrRight);
Console.WriteLine("");

Console.WriteLine();

RandMatrix = ArrUp;
count++;
index++;
}


// if ()
// {
// int [,] RightRows (int [,] matr, int i, int j, int LengthI, int Lengthj)
// {
//     int NumCell;
//     int RightStop = i+1;
//         int maxNum = matr[0,0];
//     for (int a = 0; a < matr.GetLength(0); a++)
//     {
//       for (int b = 0; b < matr.GetLength(0); b++)
//       {
//         if (matr[a,b] > maxNum)
//         maxNum = matr[a,b];
//       }  
//     }
//     for (; i < RightStop; i++)
//     {
//         NumCell = maxNum+1;
//         for (; j < Lengthj; j++)
//         {
//             matr[i, j] = NumCell++;
//         }
//     }
//     return matr;
// }
// }









