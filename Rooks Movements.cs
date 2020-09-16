using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public static string[,] CreateMatrix(ref string[,] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    arr[i, k] = "-";
                }
            }
            for (int i = 1; i < 9; i++)
            {

                for (int k = 1; k < 9; k++)
                {
                    string letter = "";
                    switch (k)
                    {
                        case 1:
                            letter = 'a' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 2:
                            letter = 'b' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 3:
                            letter = 'c' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 4:
                            letter = 'd' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 5:
                            letter = 'e' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 6:
                            letter = 'f' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 7:
                            letter = 'g' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;
                        case 8:
                            letter = 'h' + Math.Abs(i - 9).ToString();
                            arr[i, k] = letter;
                            break;

                    }
                }
            }
            return arr;
        }
        public static string[,] PutFigures(string[,] arr, int colour, string Piece, int row, int column, string position)
        {
            if (colour == 0)
            {
                for (int k = 0; k < column; k++)
                {
                    if (arr[row, k] == Piece)
                    {
                        for (int k1 = 0; k1 < k; k1++)
                        {
                            arr[row, k1] = "0";
                        }
                        break;
                    }
                }
                for (int k = 9; k > column; k--)
                {
                    if (arr[row, k] == Piece)
                    {
                        for (int k1 = 9; k1 > k; k1--)
                        {
                            arr[row, k1] = "0";
                        }
                        break;
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    if (arr[i, column] == Piece)
                    {
                        for (int i1 = 0; i1 < i; i1++)
                        {
                            arr[i1, column] = "0";
                        }
                        break;
                    }
                }
                for (int i = 9; i > row; i--)
                {
                    if (arr[i, column] == Piece)
                    {
                        for (int i1 = 9; i1 > i; i1--)
                        {
                            arr[i1, column] = "0";
                        }
                        break;
                    }
                }
            }

            else if (colour == 1)
            {
                for (int k = 0; k < column; k++)
                {
                    if (arr[row, k] == Piece)
                    {
                        for (int k1 = 0; k1 < k; k1++)
                        {
                            arr[row, k1] = "1";
                        }
                        break;
                    }
                }
                for (int k = 9; k > column; k--)
                {
                    if (arr[row, k] == Piece)
                    {
                        for (int k1 = 9; k1 > k; k1--)
                        {
                            arr[row, k1] = "1";
                        }
                        break;
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    if (arr[i, column] == Piece)
                    {
                        for (int i1 = 0; i1 < i; i1++)
                        {
                            arr[i1, column] = "1";
                        }
                        break;
                    }
                }
                for (int i = 9; i > row; i--)
                {
                    if (arr[i, column] == Piece)
                    {
                        for (int i1 = 9; i1 > i; i1--)
                        {
                            arr[i1, column] = "1";
                        }
                        break;
                    }
                }
            }
            return arr;
        }
        public static void GetCoordinates(string[,] arr, ref int row, ref int column, string pos)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int k = 1; k < 9; k++)
                {
                    if (arr[i, k] == pos)
                    {
                        row = i;
                        column = k;
                    }

                }
            }
        }
        public static void RowMovements(string[,] arr, int row, int column, string pos)
        {
        string[] xex = new string[20];
            for (int k = column; k >= 1; k--)
            {
                if (arr[row, k - 1] == "0")
                {
                    for (int v = k; v < column; v++)
                    {
                        if (v + 1 == column)
                            break;
                        Console.WriteLine("R{0}-{1}", pos, arr[row, v + 1]);
                    }
                    break;
                }
                else if (arr[row, k - 1] == "1")
                {
                    for (int v = k; v < column; v++)
                    {
                    if (v == k)
                    {
                        xex[1] = "R" + pos + "x" + arr[row, v];
                    }
                    else
                        Console.WriteLine("R{0}-{1}", pos, arr[row, v]);
                    }
                    break;
                }
                else if (arr[row, k - 1] == "-")
                {
                    for (int v = k; v < column; v++)
                    {
                        Console.WriteLine("R{0}-{1}", pos, arr[row, v]);
                    }
                    break;
                }
            }
            ColumnMovements(arr, row, column, pos, ref xex);
            for (int k = column; k < 9; k++)
            {
                if (arr[row, k + 1] == "0")
                {
                    for (int v = column; v < k; v++)
                    {
                        if (v + 1 == k)
                            break;
                        Console.WriteLine("R{0}-{1}", pos, arr[row, v + 1]);
                    }
                    break;
                }
                else if (arr[row, k + 1] == "1")
                {
                    for (int v = column + 1; v <= k; v++)
                    {
                    if (v == k)
                    {
                        xex[4] = "R" + pos + "x" + arr[row, v];
                        break;
                    }
                    else
                        Console.WriteLine("R{0}-{1}", pos, arr[row, v]);
                    }
                    break;
                }
                else if (arr[row, k + 1] == "-")
                {
                    for (int v = column; v < k; v++)
                    {
                        Console.WriteLine("R{0}-{1}", pos, arr[row, v + 1]);
                    }
                    break;
                }
            }
            for (int i = 0; i < xex.Length; i++)
        {
            if (xex[i] != null)
            Console.WriteLine(xex[i]);
        }
        }
        public static void ColumnMovements(string[,] arr, int row, int column, string pos, ref string[] xex)
        {
            for (int i = row; i < 9; i++)
            {
                if (arr[i + 1, column] == "0")
                {
                    for (int i1 = i; i1 > row; i1--)
                    {
                        if (i1 - 1 == row)
                            break;
                        Console.WriteLine("R{0}-{1}", pos, arr[i1 - 1, column]);
                    }
                    break;
                }
                else if (arr[i + 1, column] == "1")
                {
                    for (int i1 = i; i1 > row; i1--)
                    {
                    if (i1 == i)
                    {
                        xex[2] = "R" + pos + "x" + arr[i1, column];
                    }
                    else
                        Console.WriteLine("R{0}-{1}", pos, arr[i1, column]);
                            
                    }
                    break;
                }
                else if (arr[i + 1, column] == "-")
                {
                    for (int i1 = i; i1 > row; i1--)
                    {
                        Console.WriteLine("R{0}-{1}", pos, arr[i1, column]);
                    }
                    break;
                }
            }
            for (int i = row; i >= 1; i--)
            {
                if (arr[i - 1, column] == "0")
                {
                    for (int i1 = row; i1 > i + 1; i1--)
                    {
                        Console.WriteLine("R{0}-{1}", pos, arr[i1 - 1, column]);
                    }
                    break;
                }
                else if (arr[i - 1, column] == "1")
                {
                    for (int i1 = row; i1 > i; i1--)
                    {
                    if (i1 - 1 == i)
                    {
                        xex[3] = "R" + pos + "x" + arr[i1 - 1, column];
                        break;
                    }
                    else
                        Console.WriteLine("R{0}-{1}", pos, arr[i1 - 1, column]);
                    }
                    break;
                }
                else if (arr[i - 1, column] == "-")
                {
                    for (int i1 = row; i1 > i; i1--)
                    {
                        Console.WriteLine("R{0}-{1}", pos, arr[i1 - 1, column]);
                    }
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            string rookPosition = Console.ReadLine();
            int nbPieces = int.Parse(Console.ReadLine());
            string[,] matrix = new string[10, 10];
            CreateMatrix(ref matrix);
            int rowPos = 0;
            int columnPos = 0;
            GetCoordinates(matrix, ref rowPos, ref columnPos, rookPosition);

            for (int i = 0; i < nbPieces; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int colour = int.Parse(inputs[0]);
                string onePiece = inputs[1];

                PutFigures(matrix, colour, onePiece, rowPos, columnPos, rookPosition);

            }
            RowMovements(matrix, rowPos, columnPos, rookPosition);
        }
    }
