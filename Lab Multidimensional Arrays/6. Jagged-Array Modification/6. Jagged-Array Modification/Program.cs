using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            }

            while(true)
            {
                string[] command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                    break;

                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if((row>=0) && (row < matrix.Length) && (col>=0) && (col < matrix[row].Length))
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }                    
                }

                if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if ((row >= 0) && (row < matrix.Length) && (col >= 0) && (col < matrix[row].Length))
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }                    
                }

            }

            for(int i=0; i<n; i++)
            {
                for(int j=0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+" ");
                }

                Console.WriteLine();
            }

        }
    }
}
