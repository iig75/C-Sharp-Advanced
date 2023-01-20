using System;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ReadMatrix(n, matrix);

            int[,] sPosition = new int[1, 2];
            int coal = 0;
            char ch = ' ';

            coal = checkPosition(coal, sPosition, matrix);

            int newRow = sPosition[0, 0];
            int newCol = sPosition[0, 1];           

            for (int i=0; i<command.Length; i++)
            {
                if (command[i] == "up")
                {
                    if (isValidCoordinates(newRow-1, newCol, matrix))
                    {
                        newRow -= 1;
                    }
                }

                if (command[i] == "right")
                {
                    if (isValidCoordinates(newRow, newCol+1, matrix))
                    {
                        newCol += 1;
                    }
                }

                if (command[i] == "down")
                {
                    if (isValidCoordinates(newRow+1, newCol, matrix))
                    {
                        newRow += 1;
                    }
                }

                if (command[i] == "left")
                {
                    if (isValidCoordinates(newRow, newCol-1, matrix))
                    {
                        newCol -= 1;
                    }
                }

                

                if (isValidCoordinates(newRow, newCol, matrix))
                {
                    if (matrix[newRow, newCol] == 'c')
                    {
                        matrix[newRow, newCol] = '*';
                        coal--;
                    }

                    if (matrix[newRow, newCol] == 'e')
                    {
                        ch = 'e';
                        break;
                    }
                }

            }

            if(ch== 'e')
            {
                Console.WriteLine($"Game over! ({newRow}, {newCol})");
            }

            if((coal==0) && (ch != 'e'))
            {
                Console.WriteLine($"You collected all coals! ({newRow}, {newCol})");
            }

            if((coal>0) && (ch!='e'))
            {
                Console.WriteLine($"{coal} coals left. ({newRow}, {newCol})");
            }
                
        }



        public static void ReadMatrix(int n, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = char.Parse(line[j]);
                }
            }
        }



        public static int checkPosition(int coal, int[,] sPosition, char[,] matrix)
        {
            for(int row=0; row<matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col]=='s')
                    {
                        sPosition[0, 0] = row;
                        sPosition[0, 1] = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        coal++;
                    }
                }
            }

            return coal;
        }



        public static bool isValidCoordinates(int x, int y, char[,] matrix)
        {
            return
                x >= 0
                && x < matrix.GetLength(0)
                && y >= 0
                && y < matrix.GetLength(1);
        }



    }
}
