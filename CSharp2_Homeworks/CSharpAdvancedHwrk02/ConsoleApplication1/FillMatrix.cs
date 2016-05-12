using System;

namespace FillMatrix
{
    class FillMatrix
    {
        public static short[,] FillTypeA(int n)
        {
            short[,] matrixA = new short[n, n];
            short bigcounter = 1;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    int row = 0;
                    while (row < n && matrixA[row, i] == 0)
                    {
                        matrixA[row, i] = bigcounter;
                        bigcounter++;
                        row++;
                    }
                }
            } while (bigcounter <= n * n);
            return matrixA;
        }

        public static short[,] FillTypeB(int n)
        {
            short[,] matrixB = new short[n, n];
            short bigcounter = 1;
            int row = 0;
            int col = 0;
            do
            {
                while (row < n && matrixB[row, col] == 0)// filling down
                {
                    matrixB[row, col] = bigcounter;
                    bigcounter++;
                    row++;
                }
                row--;
                col++;
                if (col <= n - 1)
                {
                    while (row >= 0 && matrixB[row, col] == 0)//filling up
                    {
                        matrixB[row, col] = bigcounter;
                        bigcounter++;
                        row--;
                    }
                    col++;
                    row++;
                }
            } while (bigcounter <= n * n);
            return matrixB;
        }
        public static short[,] FillTypeC(int n)
        {
            short[,] matrixC = new short[n, n];
            short bigcounter = 1;
            int row = 0;
            int col = 0;
            int i = 0;
            while (i < n)
            {
                row = n - 1 - i;
                col = 0;
                while (row < n && row >= 0)
                {
                    matrixC[row, col] = bigcounter;
                    bigcounter++;
                    row++;
                    col++;
                }
                i++;
            }
            col = 0;
            while (i > 1)
            {
                row = 0;
                col = n - i + 1;
                while (col < n && row < n)
                {
                    matrixC[row, col] = bigcounter;
                    bigcounter++;
                    row++;
                    col++;
                }
                i--;
            }
            return matrixC;
        }

        public static short[,] FillTypeD(int n)
        {
            short[,] matrixD = new short[n, n];
            short bigcounter = 1;
            int row = 0;
            int col = 0;
            do
            {
                while (row < n && matrixD[row, col] == 0)// filling down
                {
                    matrixD[row, col] = bigcounter;
                    bigcounter++;
                    row++;
                }
                row--;
                col++;
                while (col < n && matrixD[row, col] == 0)//filling right
                {
                    matrixD[row, col] = bigcounter;
                    bigcounter++;
                    col++;
                }
                row--;
                col--;
                while (row >= 0 && matrixD[row, col] == 0)//filling up
                {
                    matrixD[row, col] = bigcounter;
                    bigcounter++;
                    row--;
                }
                col--;
                row++;
                while (col >= 0 && matrixD[row, col] == 0)//filling left
                {
                    matrixD[row, col] = bigcounter;
                    bigcounter++;
                    col--;
                }
                col++;
                row++;
            } while (bigcounter <= n * n);
            return matrixD;
        }

        public static void PrintMatrix(short[,] matrixP, int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("{0} ", matrixP[i, j]);
                }
                Console.WriteLine(matrixP[i, n - 1]);
            }
            return;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char matrixtype = char.Parse(Console.ReadLine());
            short[,] matrix = new short[n, n];

            switch (matrixtype)
            {
                case 'a': matrix = FillTypeA(n); break;
                case 'b': matrix = FillTypeB(n); break;
                case 'c': matrix = FillTypeC(n); break;
                case 'd': matrix = FillTypeD(n); break;
                default: break;
            }
            PrintMatrix(matrix, n);


        }
    }
}