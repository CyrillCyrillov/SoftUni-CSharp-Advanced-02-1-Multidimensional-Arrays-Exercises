using System;
using System.Linq;

namespace Task04_Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int columns = size[1];

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] nextLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = nextLine[column];
                }
            }

            while (true)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(comand[0] == "END")
                {
                    break;
                }

                if(comand.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int rowIndexOne = int.Parse(comand[1]);
                int columnIndexOne = int.Parse(comand[2]);
                int rowIndexTwo = int.Parse(comand[3]);
                int columnIndexTwo = int.Parse(comand[4]);

                if(comand[0] != "swap" ||
                                rowIndexOne < 0 ||
                                rowIndexOne > rows - 1 ||
                                columnIndexOne < 0 ||
                                columnIndexOne > columns - 1 ||
                                rowIndexTwo < 0 ||
                                rowIndexTwo > rows - 1 ||
                                columnIndexTwo < 0 ||
                                columnIndexTwo > columns - 1)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string temp = matrix[rowIndexOne, columnIndexOne];
                    matrix[rowIndexOne, columnIndexOne] = matrix[rowIndexTwo, columnIndexTwo];
                    matrix[rowIndexTwo, columnIndexTwo] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int column = 0; column < columns; column++)
                        {
                            Console.Write(matrix[row, column]);
                            if(column != columns - 1)
                            {
                                Console.Write(' ');
                            }
                        }

                        Console.WriteLine();
                    }
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
