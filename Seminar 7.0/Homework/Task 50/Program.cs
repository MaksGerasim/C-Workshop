// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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


int GetNumber (string Message)
{
    Console.WriteLine(Message);
    return Convert.ToInt32(Console.ReadLine());
}  


void ReturnNumberCell (int i, int j, int [,] matr)
{
    if (i > matr.GetLength(0) || j > matr.GetLength(1))
    {
        Console.WriteLine("элемента не существует");
    }
    else
    {
        Console.WriteLine($"значение элемента = {matr[i-1,j-1]}");
    }
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


const int ROWSCOUNT = 4;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
int iRow = GetNumber ("введите индекс строки i ");
int jCol = GetNumber ("введите индекс колонки j ");
ReturnNumberCell (iRow, jCol, RandMatrix);