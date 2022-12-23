

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
    int RightStop = i + 1;
    int maxNum = matr[0, 0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            if (matr[a, b] > maxNum)
                maxNum = matr[a, b];
        }
    }
    for (; i < RightStop; i++)
    {
        NumCell = maxNum + 1;
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
    int DownStop = j + 1;
    int maxNum = matr[0, 0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            if (matr[a, b] > maxNum)
                maxNum = matr[a, b];
        }
    }
    for (; j < DownStop; j++)
    {
        NumCell = maxNum + 1;
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
    int LeftStop = i - 1;
    int maxNum = matr[0, 0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            if (matr[a, b] > maxNum)
                maxNum = matr[a, b];
        }
    }
    for (; i > LeftStop; i--)
    {
        NumCell = maxNum + 1;
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
    int UpStop = j - 1;
    int maxNum = matr[0, 0];
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            if (matr[a, b] > maxNum)
                maxNum = matr[a, b];
        }
    }
    for (; j > UpStop; j--)
    {
        NumCell = maxNum + 1;
        for (; i > LengthI; i--)
        {
            matr[i, j] = NumCell++;
        }
    }
    return matr;
}

int StatusExit(int[,] RandMatrix)
{
    int status;
    if (RandMatrix.GetLength(0) <= RandMatrix.GetLength(1))
    {
        status = RandMatrix.GetLength(0) / 2;
    }
    else
    {
        status = RandMatrix.GetLength(1) / 2;
    }
    Console.WriteLine(status);
    return status;
}

int[,] OddRightRows(int[,] matr)
{
    int maxNum = matr[0, 0];
    int imax = 0;
    int jmax = 0;
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(0); b++)
        {
            if (matr[a, b] > maxNum)
            {
                maxNum = matr[a, b];
                imax = a;
                jmax = b;
            }
        }
    }
    int NumCell = maxNum + 1;
    while (matr[imax, jmax + 1] == 0)
    {
        matr[imax, jmax + 1] = NumCell++;
        jmax++;
    }
    return matr;
}

int[,] OddDownRows(int[,] matr)
{
    int maxNum = matr[0, 0];
    int imax = 0;
    int jmax = 0;
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            if (matr[a, b] > maxNum)
            {
                maxNum = matr[a, b];
                imax = a;
                jmax = b;
            }
        }
    }
    int NumCell = maxNum + 1;
    if (matr[imax, jmax + 1] == 0)
    {
        matr[imax, jmax + 1] = NumCell++;
        jmax++;
    }
    while (matr[imax + 1, jmax] == 0)
    {
        matr[imax + 1, jmax] = NumCell++;
        imax++;
    }
    return matr;
}

Console.WriteLine("введите количество строк");
int rowsCount = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int colunsCount = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("");       

int [,] RandMatrix = TwoDimensionalArray(rowsCount, colunsCount);

int count = 0;
int index = 0;
int status = StatusExit (RandMatrix);

while (count < status)
{
int RightI = 0 + index;
int RightJ = 0 + index;
int LengthI = RandMatrix.GetLength(0)-(1+index);
int Lengthj = RandMatrix.GetLength(1)-(1+index);
int [,] ArrRight= RightRows (RandMatrix, RightI, RightJ, LengthI, Lengthj);

int DownI = 0 + index;
int DownJ = RandMatrix.GetLength(1)-(1+index);
LengthI = RandMatrix.GetLength(0)-(1+index);
Lengthj = RandMatrix.GetLength(1)-(1+index);
int [,] ArrDown= DownRows (ArrRight, DownI, DownJ, LengthI, Lengthj);

int LeftI = RandMatrix.GetLength(0)-(1+index);
int LeftJ = RandMatrix.GetLength(1)-(1+index);
Lengthj = 0 + index;
int [,] ArrLift= LeftRows (ArrDown, LeftI, LeftJ, LengthI, Lengthj);

int UpI = RandMatrix.GetLength(0)-(1+index);
int UpJ = 0 + index;
LengthI = 0 + index;
int [,] ArrUp= UpRows (ArrLift, UpI, UpJ, LengthI, Lengthj);

RandMatrix = ArrUp;
count++;
index++;
}

if (RandMatrix.GetLength(0) < RandMatrix.GetLength(1))
{
    int[,] OddRight = OddRightRows(RandMatrix);
    RandMatrix = OddRight;
}
else if (RandMatrix.GetLength(1) < RandMatrix.GetLength(0))
{
    int[,] OddDown = OddDownRows(RandMatrix);
    RandMatrix = OddDown;
}
else if (RandMatrix.GetLength(1) == RandMatrix.GetLength(0))
{
    int[,] OddRight = OddRightRows(RandMatrix);
    RandMatrix = OddRight;
}
PrintMatrix(RandMatrix);










