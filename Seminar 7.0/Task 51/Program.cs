// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный


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


int AddDiagonnalNumbers(int[,] matrix)
{
    int AddNum = 0;
    int j = 0;
    int Exit = 0;
    if (matrix.GetLength(0) < matrix.GetLength(1))
    {
        Exit = matrix.GetLength(0);
    }
    else
    {
        Exit = matrix.GetLength(1);
    }
    for (int i = 0; i < Exit; i++)
    {
        AddNum += matrix[i, j];
        j++;
    }
    return AddNum;
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



const int ROWSCOUNT = 10;
const int COLUNSCOUNT = 4;       
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
Console.WriteLine();
int AddDiag = AddDiagonnalNumbers(RandMatrix);
Console.WriteLine($"сумма элементтов диагонали = {AddDiag}");