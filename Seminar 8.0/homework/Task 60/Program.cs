// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1


int[,,] RandomThryDimensionalArray(int rowsCount, int colunsCount, int deepCount,int leftRange, int rightRange)
{
    int[,,] array = new int[rowsCount, colunsCount, deepCount];

    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int u = 0; u < array.GetLength(2); u++)
            {
                array[i, j, u] = rand.Next(leftRange, rightRange + 1);
                Console.Write(array[i,j,u]+" ");
            }
            
        }
    }
    Console.WriteLine(" ");
    return array;
}


void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine("");
            for (int u = 0; u < matr.GetLength(2); u++)
            {
                Console.Write($"{matr[i,j, u]} ({i},{j},{u})   ");
            }
        }
    }
}

const int ROWSCOUNT = 2;
const int COLUNSCOUNT = 2;
const int DEEPCOUNT = 2;  
const int lEFTRANGE = 1;
const int RIGHTRANGE = 9;

int [,,] RandMatrix = RandomThryDimensionalArray(ROWSCOUNT, COLUNSCOUNT, DEEPCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
Console.WriteLine("");
