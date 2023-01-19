using System;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            ReadMatrix(n, matrix);

            int countAttackedKnight = 0;

            int removedKnight = 0;

            while (true)
            {
                int maxAttackedKnight = 0;
                int maxAttackedRow = 0;
                int maxAttackedCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            countAttackedKnight = checkPositions(row, col, matrix);

                            if (countAttackedKnight > maxAttackedKnight)
                            {
                                maxAttackedKnight = countAttackedKnight;
                                maxAttackedRow = row;
                                maxAttackedCol = col;
                            }
                        }
                    }
                }

                if (maxAttackedKnight > 0)
                {
                    matrix[maxAttackedRow, maxAttackedCol] = '0';
                    removedKnight++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedKnight);
        }



        public static void ReadMatrix(int n, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {

                string line = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

        }



        public static bool isValidCoordinates(int row, int col, char[,] matrix)
        {
            return
                row >= 0
                && row < matrix.GetLength(0)
                && col >= 0
                && col < matrix.GetLength(1);
        }



        public static int checkPositions(int row, int col, char[,] matrix)
        {
            int countAttackedKnight = 0;

            //Up - Left
            if (isValidCoordinates(row - 2, col - 1, matrix))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Up - Right
            if (isValidCoordinates(row - 2, col + 1, matrix))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Right - Up
            if (isValidCoordinates(row - 1, col + 2, matrix))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Right - Down
            if (isValidCoordinates(row + 1, col + 2, matrix))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Down - Left
            if (isValidCoordinates(row + 2, col + 1, matrix))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Down - Right
            if (isValidCoordinates(row + 2, col - 1, matrix))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Left - Down
            if (isValidCoordinates(row + 1, col - 2, matrix))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            //Left - Up
            if (isValidCoordinates(row - 1, col - 2, matrix))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    countAttackedKnight++;
                }
            }

            return countAttackedKnight;
        }

    }
}
