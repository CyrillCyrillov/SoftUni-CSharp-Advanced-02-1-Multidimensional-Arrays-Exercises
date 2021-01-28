using System;
using System.Linq;

namespace Task02_2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];

            char[,] matrix = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string nextLine = Console.ReadLine();
                nextLine = String.Concat(nextLine.Where(c => !Char.IsWhiteSpace(c)));
                
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = nextLine[column];
                }
            }

            int counter = 0;

            for (int row = 0; row <= rows - 2; row++)
            {
                for (int column = 0; column <= columns - 2; column++)
                {
                    if(matrix[row,column] == matrix[row + 1, column] && matrix[row, column] == matrix[row, column + 1] && matrix[row, column] == matrix[row + 1, column + 1] )
                    {
                        counter++;
                    }
                }
            }



            Console.WriteLine(counter);
        }
    }
}
