using System;
using System.Linq;

namespace Task07_Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int tableSize = int.Parse(Console.ReadLine());
            char[,] table = new char[tableSize, tableSize];

            for (int row = 0; row < tableSize; row++)
            {
                string nextLine = Console.ReadLine();
                for (int column = 0; column < tableSize; column++)
                {
                    table[row, column] = nextLine[column];
                }
            }

            bool isHaveActiveKnight = true;
            int countRemovedKnight = 0;

            while (isHaveActiveKnight)
            {
                isHaveActiveKnight = false;
                int maxAtackTargets = 0;
                int[] knightToRemove = new int[]{ -1, -1 };

                for (int row = 0; row < tableSize; row++)
                {
                    for (int column = 0; column < tableSize; column++)
                    {
                        if(table[row, column] == 'K')
                        {
                            int atackTargets = 0;

                            int nextRow = row - 1;
                            int nextColumn = column - 2;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            nextRow = row - 2;
                            nextColumn = column - 1;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            nextRow = row - 2;
                            nextColumn = column + 1;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            nextRow = row - 1;
                            nextColumn = column + 2;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            nextRow = row + 1;
                            nextColumn = column + 2;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            nextRow = row + 2;
                            nextColumn = column + 1;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            nextRow = row + 2;
                            nextColumn = column - 1;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            
                            nextRow = row + 1;
                            nextColumn = column - 2;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }

                            /*
                            nextRow = row + 1;
                            nextColumn = column - 2;
                            if (IsCorect(nextRow, nextColumn, tableSize))
                            {
                                if (table[nextRow, nextColumn] == 'K')
                                {
                                    isHaveActiveKnight = true;
                                    atackTargets++;
                                }
                            }
                            */

                            if (atackTargets > maxAtackTargets)
                            {
                                maxAtackTargets = atackTargets;
                                knightToRemove = new int[] { row, column };
                            }

                        }
                    }
                }

                if(isHaveActiveKnight)
                {
                    table[knightToRemove[0], knightToRemove[1]] = '0';
                    countRemovedKnight++;
                }
            }
            
            
            Console.WriteLine(countRemovedKnight);
        }

        private static bool IsCorect(int nextRow, int nextColumn, int tableSize)
        {
            if(nextRow >= 0 && nextRow < tableSize &&
                nextColumn >= 0 && nextColumn < tableSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
