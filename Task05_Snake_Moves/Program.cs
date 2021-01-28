using System;
using System.Linq;

namespace Task05_Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int columns = sizes[1];
            char[,] snakeTrack = new char[rows, columns];

            string snake = Console.ReadLine();

            int curentIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if(row % 2 == 0)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        snakeTrack[row, column] = snake[curentIndex];
                        curentIndex++;
                        if(curentIndex == snake.Length)
                        {
                            curentIndex = 0;
                        }
                    }
                }
                else
                {
                    for (int column = columns - 1; column >=  0; column--)
                    {
                        snakeTrack[row, column] = snake[curentIndex];
                        curentIndex++;
                        if (curentIndex == snake.Length)
                        {
                            curentIndex = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(snakeTrack[row, column]);
                }
                Console.WriteLine();
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
