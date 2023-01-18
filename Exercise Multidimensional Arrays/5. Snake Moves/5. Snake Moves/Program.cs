using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            string word = Console.ReadLine();

            int currentWordIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if(row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (currentWordIndex == word.Length)
                        {
                            currentWordIndex = 0;
                        }

                        matrix[row, col] = word[currentWordIndex];
                        currentWordIndex++;
                    }                    
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (currentWordIndex == word.Length)
                        {
                            currentWordIndex = 0;
                        }

                        matrix[row, col] = word[currentWordIndex];
                        currentWordIndex++;
                    }
                }
            }

            PrintMatrix(matrix);
        }



        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
