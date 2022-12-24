// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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



void ArithmeticMeanColunsMatrix (int [,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double ArithmeticMean = 0;
        int i = 0;
        for (; i < matr.GetLength(0); i++)
        {
            ArithmeticMean += matr [i,j];
            
        }
        ArithmeticMean = ArithmeticMean/i;
        
        Console.Write ($"{ArithmeticMean:f2}; "); 
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


const int ROWSCOUNT = 2;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
Console.WriteLine("среднее арифметическое каждого столбца:");
ArithmeticMeanColunsMatrix (RandMatrix);
   
