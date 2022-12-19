// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] TwoDimensionalMatrix (int rowsCount, int colunsCount)
{
    int[,] array = new int[rowsCount, colunsCount];
     
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}


int GetNumber (string Message)
{
    Console.WriteLine(Message);
    return Convert.ToInt32(Console.ReadLine());
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


int rowsCount = GetNumber ("введите число строк");
int colunsCount = GetNumber ("введите число колонок");
int [,] Mart = TwoDimensionalMatrix(rowsCount, colunsCount);
PrintMatrix (Mart);












































