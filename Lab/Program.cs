

//         int[,] TwoDimensionalArray(int rowsCount, int colunsCount)
//         {
//             int[,] array = new int[rowsCount, colunsCount];
//             return array;
//         }

//         void PrintMatrix(int[,] matr)
//         {
//             for (int i = 0; i < matr.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matr.GetLength(1); j++)
//                 {
//                     Console.Write(matr[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         int[,] RightRows(int[,] matr, int i, int j, int LengthI, int Lengthj)
//         {
//             int NumCell;
//             int RightStop = i + 1;
//             int maxNum = matr[0, 0];
//             for (int a = 0; a < matr.GetLength(0); a++)
//             {
//                 for (int b = 0; b < matr.GetLength(1); b++)
//                 {
//                     if (matr[a, b] > maxNum)
//                         maxNum = matr[a, b];
//                 }
//             }
//             for (; i < RightStop; i++)
//             {
//                 NumCell = maxNum + 1;
//                 for (; j < Lengthj; j++)
//                 {
//                     matr[i, j] = NumCell++;
//                 }
//             }
//             return matr;
//         }

//         int[,] DownRows(int[,] matr, int i, int j, int LengthI, int Lengthj)
//         {
//             int NumCell;
//             int DownStop = j + 1;
//             int maxNum = matr[0, 0];
//             for (int a = 0; a < matr.GetLength(0); a++)
//             {
//                 for (int b = 0; b < matr.GetLength(1); b++)
//                 {
//                     if (matr[a, b] > maxNum)
//                         maxNum = matr[a, b];
//                 }
//             }
//             for (; j < DownStop; j++)
//             {
//                 NumCell = maxNum + 1;
//                 for (; i < LengthI; i++)
//                 {
//                     matr[i, j] = NumCell++;
//                 }
//             }
//             return matr;
//         }

//         int[,] LeftRows(int[,] matr, int i, int j, int LengthI, int Lengthj)
//         {
//             int NumCell;
//             int LeftStop = i - 1;
//             int maxNum = matr[0, 0];
//             for (int a = 0; a < matr.GetLength(0); a++)
//             {
//                 for (int b = 0; b < matr.GetLength(1); b++)
//                 {
//                     if (matr[a, b] > maxNum)
//                         maxNum = matr[a, b];
//                 }
//             }
//             for (; i > LeftStop; i--)
//             {
//                 NumCell = maxNum + 1;
//                 for (; j > Lengthj; j--)
//                 {
//                     matr[i, j] = NumCell++;
//                 }
//             }
//             return matr;
//         }

//         int[,] UpRows(int[,] matr, int i, int j, int LengthI, int Lengthj)
//         {
//             int NumCell;
//             int UpStop = j - 1;
//             int maxNum = matr[0, 0];
//             for (int a = 0; a < matr.GetLength(0); a++)
//             {
//                 for (int b = 0; b < matr.GetLength(1); b++)
//                 {
//                     if (matr[a, b] > maxNum)
//                         maxNum = matr[a, b];
//                 }
//             }
//             for (; j > UpStop; j--)
//             {
//                 NumCell = maxNum + 1;
//                 for (; i > LengthI; i--)
//                 {
//                     matr[i, j] = NumCell++;
//                 }
//             }
//             return matr;
//         }

//         int StatusExit(int[,] RandMatrix)
//         {
//             int status;
//             if (RandMatrix.GetLength(0) <= RandMatrix.GetLength(1))
//             {
//                 status = RandMatrix.GetLength(0) / 2;
//             }
//             else
//             {
//                 status = RandMatrix.GetLength(1) / 2;
//             }
//             //Console.WriteLine(status);
//             return status;
//         }

//         int[,] OddRightRows(int[,] matr)
//         {
//             int maxNum = matr[0, 0];
//             int imax = 0;
//             int jmax = 0;
//             for (int a = 0; a < matr.GetLength(0); a++)
//             {
//                 for (int b = 0; b < matr.GetLength(0); b++)
//                 {
//                     if (matr[a, b] > maxNum)
//                     {
//                         maxNum = matr[a, b];
//                         imax = a;
//                         jmax = b;
//                     }
//                 }
//             }
//             int NumCell = maxNum + 1;
//             while (matr[imax, jmax + 1] == 0)
//             {
//                 matr[imax, jmax + 1] = NumCell++;
//                 jmax++;
//             }
//             return matr;
//         }

//         int[,] OddDownRows(int[,] matr)

//         {
//             int maxNum = matr[0, 0];
//             int imax = 0;
//             int jmax = 0;
//             for (int a = 0; a < matr.GetLength(0); a++)
//             {
//                 for (int b = 0; b < matr.GetLength(1); b++)
//                 {
//                     if (matr[a, b] > maxNum)
//                     {
//                         maxNum = matr[a, b];
//                         imax = a;
//                         jmax = b;
//                     }
//                 }
//             }
//             int NumCell = maxNum + 1;
//             if (matr[imax, jmax + 1] == 0)
//             {
//                 matr[imax, jmax + 1] = NumCell++;
//                 jmax++;
//             }
//             while (matr[imax + 1, jmax] == 0)
//             {
//                 matr[imax + 1, jmax] = NumCell++;
//                 imax++;
//             }
//             return matr;
//         }

// int [,] SpiralArray (int[,] matrix)
// {
//     int i =0;
//     int j =0;
//     int  NumCell =0;
//     int LengthHorizontal = matrix.GetLength(0) - 1;
//     int LengthVertical = matrix.GetLength(1) - 1;
//     int Count = 0;
   
//     int turn = 0;  // 0 - заполняет горизонт, 1 - заполняет вертикаль


//     while (Count < 2)
//     {
//         if (turn == 0)
//         {
//             for (; i < LengthHorizontal; i++)
//                 for (; j < LengthVertical; j++)
//                 {
//                     matrix[i, j] = NumCell++;
//                 }
//         }
//         else
//         {
//             for (; j < LengthVertical; j++)
//                 for (; i < LengthHorizontal; i++)
//                 {
//                     matrix[i, j] = NumCell++;
//                 }

//             if (turn == 0)
//             {
//                 turn = 1;
//             }
//             else
//             {
//                 turn = 0;
//             }
//             Count++;
//         }
//     }

//     while (Count < 4)
//     {
//         if (turn == 0)
//         {
//             for (; Static < LengthHorizontal; Static--)
//                 for (; Move < LengthVertical; Move--)
//                 {
//                     matrix[i, j] = NumCell++;
//                 }
//         }
//         else
//         {
//             for (; Static < LengthVertical; Static--)
//                 for (; Move < LengthHorizontal; Move--)
//                 {
//                     matrix[j, i] = NumCell++;
//                 }

//             if (turn == 0)
//             {
//                 turn = 1;
//             }
//             else
//             {
//                 turn = 0;
//             }
//             Count++;
//         }
//     }
//     Count = 0;

// }





//         Console.WriteLine("введите количество строк");
//         int rowsCount = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("введите количество столбцов");
//         int colunsCount = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("");
//         int[,] RandMatrix = TwoDimensionalArray(rowsCount, colunsCount);
//         PrintMatrix(RandMatrix);
//         RandMatrix [0,0] = 1;
//         Console.WriteLine("");
//         PrintMatrix(RandMatrix);










