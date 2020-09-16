using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
        public static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            string[,] matrix = new string[H, W];

            for (int i = 0; i < H; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < W; j++)
                {
                    matrix[i, j] = inputs[j];
                }
            }

            FindTheTreasure(matrix, out int x, out int y);
            Console.WriteLine("{0} {1}", y, x);
        }
        public static void FindTheTreasure(string[,] matrix, out int x, out int y)
        {
            bool found = false;
            y = 0;

            for (x = 0; x < matrix.GetLength(0); x++)
            {
                for (y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] != "0")
                        continue;
                    if (x == 0 && y == 0)
                    {
                        if (matrix[x, y + 1] == "1" && matrix[x + 1, y + 1] == "1" && matrix[x + 1, y] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x == 0 && y == matrix.GetLength(1) - 1)
                    {
                        if (matrix[x, y - 1] == "1" && matrix[x + 1, y - 1] == "1" && matrix[x + 1, y] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x == matrix.GetLength(0) - 1 && y == 0)
                    {
                        if (matrix[x - 1, y] == "1" && matrix[x - 1, y + 1] == "1" && matrix[x, y + 1] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x == matrix.GetLength(0) - 1 && y == matrix.GetLength(1) - 1)
                    {
                        if (matrix[x, y - 1] == "1" && matrix[x - 1, y] == "1" && matrix[x - 1, y - 1] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x == 0 && y >= 1 && y <= matrix.GetLength(1) - 2)
                    {
                        if (matrix[x, y - 1] == "1" && matrix[x, y + 1] == "1" && matrix[x + 1, y - 1] == "1" && matrix[x + 1, y] == "1" && matrix[x + 1, y + 1] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x == matrix.GetLength(0) - 1 && y >= 1 && y <= matrix.GetLength(1) - 2)
                    {
                        if (matrix[x, y - 1] == "1" && matrix[x - 1, y - 1] == "1" && matrix[x - 1, y] == "1" && matrix[x - 1, y + 1] == "1" && matrix[x, y + 1] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x >= 1 && x <= matrix.GetLength(0) - 2 && y == 0)
                    {
                        if (matrix[x - 1, y] == "1" && matrix[x - 1, y + 1] == "1" && matrix[x, y + 1] == "1" && matrix[x + 1, y + 1] == "1" && matrix[x + 1, y] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x >= 1 && x <= matrix.GetLength(0) - 2 && y == matrix.GetLength(1) - 1)
                    {
                        if (matrix[x - 1, y] == "1" && matrix[x - 1, y - 1] == "1" && matrix[x, y - 1] == "1" && matrix[x + 1, y - 1] == "1" && matrix[x + 1, y] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    else if (x >= 1 && x <= matrix.GetLength(0) - 2 && y >= 1 && y <= matrix.GetLength(1) - 2)
                    {
                        if (matrix[x - 1, y - 1] == "1" && matrix[x - 1, y] == "1" && matrix[x - 1, y + 1] == "1" && matrix[x, y + 1] == "1" && matrix[x + 1, y + 1] == "1" && matrix[x + 1, y] == "1" && matrix[x + 1, y - 1] == "1" && matrix[x, y - 1] == "1")
                        {
                            found = true;
                            break;
                        }
                    }
                    
                }
                if (found)
                    break;
            }
        }
}
