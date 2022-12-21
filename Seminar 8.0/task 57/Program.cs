// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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

void PrinArrayLogNum(int[] matr)
{
    int NumLog = 0;
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine($"число {NumLog} встречается {matr[i]} раз");
        NumLog++;
    }
    Console.WriteLine();

}


int [] LogNumberMatrix (int [,] matr) // поиск количества встречающихся значений в матрице
{
    int[] res = new int[11];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            res[matr[i,j]]++;

        }
    }   
    return res;

}



const int ROWSCOUNT = 3;
const int COLUNSCOUNT = 3;       
const int lEFTRANGE = 0;
const int RIGHTRANGE = 10;


int [,] RandMatrix = RandomTwoDimensionalArray(ROWSCOUNT, COLUNSCOUNT, lEFTRANGE, RIGHTRANGE);
PrintMatrix(RandMatrix);
int [] ArrLog = LogNumberMatrix (RandMatrix);
PrinArrayLogNum (ArrLog);