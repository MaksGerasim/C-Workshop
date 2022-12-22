//  Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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

int [] AddNumberRows(int[,] matrix)
{
    int[] TempArray = new int[matrix.GetLength(0)];
    
    int u = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int AddNumRows = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            AddNumRows = AddNumRows + matrix[i, j];
        }
        Console.WriteLine(AddNumRows);
        TempArray[u] = AddNumRows;
        u++;
        Console.WriteLine(string.Join(",", TempArray));
    }
return TempArray;
}

void MinRows(int[] TempArray)
{
int MinNum = TempArray[0];
Console.WriteLine(string.Join(",", TempArray));
    for (int y = 0; y < TempArray.Length; y++)
    {
        if (TempArray[y] <= MinNum)
        {
            MinNum = TempArray[y];
        }
    }    
    for (int g = 0; g < TempArray.Length; g++)   
    { 
        if (TempArray[g] == MinNum)
        {
            Console.WriteLine($"строка с минимальным значеением {g + 1}");
        }
    }
}

const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
Console.WriteLine("");
int [] Arr = AddNumberRows(RandMatrix);
MinRows (Arr);

