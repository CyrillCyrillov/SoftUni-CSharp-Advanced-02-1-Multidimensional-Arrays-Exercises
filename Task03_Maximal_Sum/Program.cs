using System;
using System.Linq;

namespace Task03_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int columns = size[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] nextLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = nextLine[column];
                }
            }

            int maxSum = int.MinValue;
            int lookIndexRow = -1;
            int lookIndexColumn = -1;

            for (int row = 0; row <= rows - 3; row++)
            {
                for (int column = 0; column <= columns - 3; column++)
                {
                    int curentSum = matrix[row, column] + matrix[row, column + 1] + matrix[row, column + 2] +
                                    matrix[row + 1, column] + matrix[row + 1, column + 1] + matrix[row + 1, column + 2] +
                                    matrix[row + 2, column] + matrix[row + 2, column + 1] + matrix[row + 2, column + 2];

                    if(curentSum > maxSum)
                    {
                        maxSum = curentSum;
                        lookIndexRow = row;
                        lookIndexColumn = column;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine($"{matrix[lookIndexRow, lookIndexColumn]} {matrix[lookIndexRow, lookIndexColumn + 1]} {matrix[lookIndexRow, lookIndexColumn + 2]}");
            Console.WriteLine($"{matrix[lookIndexRow + 1, lookIndexColumn]} {matrix[lookIndexRow + 1, lookIndexColumn + 1]} {matrix[lookIndexRow + 1, lookIndexColumn + 2]}");
            Console.WriteLine($"{matrix[lookIndexRow + 2, lookIndexColumn]} {matrix[lookIndexRow + 2, lookIndexColumn + 1]} {matrix[lookIndexRow + 2, lookIndexColumn + 2]}");

            //Console.WriteLine("Hello World!");
        }
    }
}
