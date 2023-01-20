using System;
using System.Dynamic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
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

            ReadMatrix(rows, cols, matrix);

            string command = Console.ReadLine();

            int[] deadCoordinates = {-1, -1};
            
            int[] winCoordinates = { -1, -1 };

            int[] playerCoordinates = new int[2];

            initPlayerCoordinates(playerCoordinates, matrix);

            for(int step=0; step<command.Length; step++)
            {
                playerMove(winCoordinates, deadCoordinates, playerCoordinates, command[step], matrix);

                multiplayBunnyes(deadCoordinates, matrix);

                if ((winCoordinates[0] != -1) && (winCoordinates[1] != -1))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {winCoordinates[0]} {winCoordinates[1]}");
                    break;
                }

                if ((deadCoordinates[0] != -1) && (deadCoordinates[1] != -1))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {deadCoordinates[0]} {deadCoordinates[1]}");
                    break;
                }
            }
        }



        public static void ReadMatrix(int rows, int cols, char[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {

                string line = Console.ReadLine();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
        }



        public static void initPlayerCoordinates(int[] playerCoordinates, char[,] matrix)
        {
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j=0;  j<matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]=='P')
                    {
                        playerCoordinates[0] = i;
                        playerCoordinates[1] = j;
                    }
                }
            }
        }



        public static bool isValidCoordinate(int x, int y, char[,] matrix)
        {
            return
                x >= 0
                && x < matrix.GetLength(0)
                && y >= 0
                && y < matrix.GetLength(1);
        }



        public static void playerMove(int[] winCoordinates, int[] deadCoordinates, int[] playerCoordinates, char ch, char[,] matrix)
        {
            //UPPER
            if (ch == 'U')
            {
                if (isValidCoordinate(playerCoordinates[0] - 1, playerCoordinates[1], matrix))
                {
                    if (matrix[playerCoordinates[0] - 1, playerCoordinates[1]] == 'B')
                    {
                        deadCoordinates[0] = playerCoordinates[0] - 1;
                        deadCoordinates[1] = playerCoordinates[1];
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    }

                    if (matrix[playerCoordinates[0] - 1, playerCoordinates[1]] == '.')
                    {
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                        matrix[playerCoordinates[0] - 1, playerCoordinates[1]] = 'P';
                        playerCoordinates[0] -= 1;
                    }
                }
                else
                {
                    winCoordinates[0] = playerCoordinates[0];
                    winCoordinates[1] = playerCoordinates[1];
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                }
            }

            //RIGHT
            if (ch == 'R')
            {
                if (isValidCoordinate(playerCoordinates[0], playerCoordinates[1]+1, matrix))
                {
                    if (matrix[playerCoordinates[0], playerCoordinates[1] + 1] == 'B')
                    {
                        deadCoordinates[0] = playerCoordinates[0];
                        deadCoordinates[1] = playerCoordinates[1] + 1;
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    }

                    if (matrix[playerCoordinates[0], playerCoordinates[1]+1] == '.')
                    {
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                        matrix[playerCoordinates[0], playerCoordinates[1]+1] = 'P';
                        playerCoordinates[1] += 1;
                    }
                }
                else
                {
                    winCoordinates[0] = playerCoordinates[0];
                    winCoordinates[1] = playerCoordinates[1];
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                }
            }

            //DOWN
            if (ch == 'D')
            {
                if (isValidCoordinate(playerCoordinates[0]+1, playerCoordinates[1], matrix))
                {
                    if (matrix[playerCoordinates[0] + 1, playerCoordinates[1]] == 'B')
                    {
                        deadCoordinates[0] = playerCoordinates[0] + 1;
                        deadCoordinates[1] = playerCoordinates[1];
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    }

                    if (matrix[playerCoordinates[0]+1, playerCoordinates[1]] == '.')
                    {
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                        matrix[playerCoordinates[0]+1, playerCoordinates[1]] = 'P';
                        playerCoordinates[0] += 1;
                    }
                }
                else
                {
                    winCoordinates[0] = playerCoordinates[0];
                    winCoordinates[1] = playerCoordinates[1];
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                }
            }

            //LEFT
            if (ch == 'L')
            {
                if (isValidCoordinate(playerCoordinates[0], playerCoordinates[1]-1, matrix))
                {
                    if (matrix[playerCoordinates[0], playerCoordinates[1] - 1] == 'B')
                    {
                        deadCoordinates[0] = playerCoordinates[0];
                        deadCoordinates[1] = playerCoordinates[1] - 1;
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                    }

                    if (matrix[playerCoordinates[0], playerCoordinates[1]-1] == '.')
                    {
                        matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                        matrix[playerCoordinates[0], playerCoordinates[1]-1] = 'P';
                        playerCoordinates[1] -= 1;
                    }
                }
                else
                {
                    winCoordinates[0] = playerCoordinates[0];
                    winCoordinates[1] = playerCoordinates[1];
                    matrix[playerCoordinates[0], playerCoordinates[1]] = '.';
                }
            }
        }


                
        public static void multiplayBunnyes(int[] deadCoodrinates, char[,] matrix)
        {
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]=='B')
                    {
                        //UP
                        if(isValidCoordinate(i-1, j, matrix))
                        {
                            if (matrix[i-1, j] == '.')
                            {
                                matrix[i-1, j] = 'Z';
                            }

                            if (matrix[i - 1, j] == 'P')
                            {
                                deadCoodrinates[0] = i - 1;
                                deadCoodrinates[1] = j;
                                matrix[i - 1, j] = 'Z';
                            }
                        }

                        //RIGHT
                        if (isValidCoordinate(i, j+1, matrix))
                        {
                            if (matrix[i, j+1] == '.')
                            {
                                matrix[i, j+1] = 'Z';
                            }

                            if (matrix[i, j+1] == 'P')
                            {
                                deadCoodrinates[0] = i;
                                deadCoodrinates[1] = j+1;
                                matrix[i, j + 1] = 'Z';
                            }
                        }

                        //DOWN
                        if (isValidCoordinate(i+1, j, matrix))
                        {
                            if (matrix[i+1, j] == '.')
                            {
                                matrix[i+1, j] = 'Z';
                            }

                            if (matrix[i+1, j] == 'P')
                            {
                                deadCoodrinates[0] = i+1;
                                deadCoodrinates[1] = j;
                                matrix[i + 1, j] = 'Z';
                            }
                        }

                        //LEFT
                        if (isValidCoordinate(i, j-1, matrix))
                        {
                            if (matrix[i, j-1] == '.')
                            {
                                matrix[i, j-1] = 'Z';
                            }

                            if (matrix[i, j-1] == 'P')
                            {
                                deadCoodrinates[0] = i;
                                deadCoodrinates[1] = j-1;
                                matrix[i, j - 1] = 'Z';
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]=='Z')
                    {
                        matrix[i, j] = 'B';
                    }
                }
            }

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
