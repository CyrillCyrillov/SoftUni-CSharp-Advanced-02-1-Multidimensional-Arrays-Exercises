using System;
using System.Linq;

namespace Task06_Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedMatrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] nextLineData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                jaggedMatrix[row] = new double[nextLineData.Length];
                for (int column = 0; column < nextLineData.Length; column++)
                {
                    jaggedMatrix[row][column] = nextLineData[column];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if(jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                {
                    int helpVar = jaggedMatrix[row].Length;
                    for (int i = 0; i < helpVar; i++)
                    {
                        jaggedMatrix[row][i] *= 2;
                        jaggedMatrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedMatrix[row].Length; i++)
                    {
                        jaggedMatrix[row][i] /= 2;
                    }
                    for (int i = 0; i < jaggedMatrix[row + 1].Length; i++)
                    {
                        jaggedMatrix[row + 1][i] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(comand[0].ToUpper() == "END" )
                {
                    break;
                }

                string typeComand = comand[0];
                int rowIndex = int.Parse(comand[1]);
                int columnIndex = int.Parse(comand[2]);
                int value = int.Parse(comand[3]);

                switch (typeComand.ToUpper())
                {
                    case "SUBTRACT":
                        if(rowIndex >= 0 &&
                            rowIndex < rows &&
                            columnIndex >= 0 &&
                            columnIndex < jaggedMatrix[rowIndex].Length)
                        {
                            jaggedMatrix[rowIndex][columnIndex] -= value;
                        }
                        break;

                    case "ADD":
                        if (rowIndex >= 0 &&
                            rowIndex < rows &&
                            columnIndex >= 0 &&
                            columnIndex < jaggedMatrix[rowIndex].Length)
                        {
                            jaggedMatrix[rowIndex][columnIndex] += value;
                        }
                        break;


                    default:
                        break;
                }
            }

            foreach (var elements in jaggedMatrix)
            {
                Console.WriteLine(string.Join(' ', elements));
            }
        }
    }
}
