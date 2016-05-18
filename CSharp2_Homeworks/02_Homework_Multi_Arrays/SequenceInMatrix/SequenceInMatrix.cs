using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            string[] size = Console.ReadLine().Split(' ');

            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);

            string[,] matrix = new string[rows,columns];

            // Initialize the matrix with string elements

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = line[col];

                }
            }

            int bestRowSequence = RowSequence(matrix, rows, columns);
            int bestColSequence = ColSequence(matrix, rows, columns);

            int lengthLeft = 1;
            int lengthRight = rows - columns;  //-2
            int bestLeftDiagonalSequence = 1;
            int bestRightDiagonalSequence = 1;

            bestLeftDiagonalSequence = LeftDiagonalSequence(matrix, rows, columns, lengthLeft, bestLeftDiagonalSequence);
            bestRightDiagonalSequence = RightDiagonalSequence(matrix, rows, columns, lengthRight, bestRightDiagonalSequence);


            int result = Math.Max(bestLeftDiagonalSequence, Math.Max(bestLeftDiagonalSequence, Math.Max(bestRowSequence, bestColSequence)));
            Console.WriteLine(result);
        }



        private static int RowSequence(string[,] matrix, int rows, int columns)
        {
            int bestCountDimension = 1;
            int currentCount = 1;

            for (int row = 0; row < rows; row++)
            {
                currentCount = 1;
                for (int col = 0; col < columns - 1; col++)
                {

                    if (matrix[row, col].Equals(matrix[row, col + 1]))
                    {
                        currentCount++;
                        bestCountDimension = Math.Max(currentCount, bestCountDimension);
                    }
                    else
                    {
                        currentCount = 1;
                    }

                }
            }
            return bestCountDimension;
        }

        //
        private static int ColSequence(string[,] matrix, int rows, int columns)
        {
            int bestCountDimension = 1;
            int currentCount = 1;

            for (int col = 0; col < columns; col++)
            {
                currentCount = 1;
                for (int row = 0; row < rows - 1; row++)
                {

                    if (matrix[row, col].Equals(matrix[row + 1, col]))
                    {
                        currentCount++;
                        bestCountDimension = Math.Max(currentCount, bestCountDimension);
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }
            }
            return bestCountDimension;
        }

        //
        private static int LeftDiagonalSequence(string[,] matrix, int rows, int columns, int lengthLeft, int bestLeftDiagonalSequence)
        {
            string currentValue;
            string previousValue = "null";
            int currentCount = 1;


            if (lengthLeft == rows + columns - 2) //8
            {
                return bestLeftDiagonalSequence;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (row + col == lengthLeft)
                    {
                        currentValue = matrix[row, col];
                        if (previousValue.Equals(currentValue))
                        {
                            currentCount++;
                            bestLeftDiagonalSequence = Math.Max(bestLeftDiagonalSequence, currentCount);
                        }
                        else
                        {
                            currentCount = 1;
                        }
                        previousValue = currentValue;

                    }
                }
            }
            return LeftDiagonalSequence(matrix, rows, columns, lengthLeft + 1, bestLeftDiagonalSequence);
        }

        
        private static int RightDiagonalSequence(string[,] matrix, int rows, int columns, int lengthRight, int bestRightDiagonalSequence)
        {
            string currentValue;
            string previousValue = "null";
            int currentCount = 1;


            if (lengthRight == columns - 1)
            {
                return bestRightDiagonalSequence;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (col - row == lengthRight)
                    {
                        currentValue = matrix[row, col];
                        if (previousValue.Equals(currentValue))
                        {
                            currentCount++;
                            bestRightDiagonalSequence = Math.Max(bestRightDiagonalSequence, currentCount);
                        }
                        else
                        {
                            currentCount = 1;
                        }
                        previousValue = currentValue;

                    }
                }
            }
            return RightDiagonalSequence(matrix, rows, columns, lengthRight + 1, bestRightDiagonalSequence);
        }

    }
}