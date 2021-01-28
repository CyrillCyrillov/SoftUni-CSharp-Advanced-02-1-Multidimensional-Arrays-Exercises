using System;
using System.Linq;

namespace Task01_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimension, dimension];

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < dimension; row++)
            {
                int[] nextRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int colum = 0; colum < dimension; colum++)
                {
                    matrix[row, colum] = nextRow[colum];
                    if(row == colum)
                    {
                        primaryDiagonalSum += matrix[row, colum];
                    }
                    if(row + colum + 1 == dimension)
                    {
                        secondaryDiagonalSum += matrix[row, colum];
                    }
                }
            }
            
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));

            //Console.WriteLine(primaryDiagonalSum);
            //Console.WriteLine(secondaryDiagonalSum);
        }
    }
}
