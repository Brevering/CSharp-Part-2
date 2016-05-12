using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        static void Main()
        {

            string[] size = Console.ReadLine().Split(' ');

            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);

            string[,] matrix = new string[rows, columns];

            // Initialize the matrix with string elements

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = line[col];

                }
            }

        }
    }
}
