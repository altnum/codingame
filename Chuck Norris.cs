using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public static string ToBinary(string str)
    {


        int elements = 0;

        foreach (char ch in str)
            elements++;
        string[] arr = new string[elements];
        int i = 0;
        foreach (char ch in str)
        {
            string output = "";

            int length = 0;
            int num = ch;
            output += Convert.ToString(num, 2);
            //
            foreach (char ch1 in output)
            {
                length++;
            }

            string add = "";
            if (length < 7)
            {
                for (int x = 0; x < 7 - length; x++)
                    add += "0";
            }
            output = add + output;
            arr[i] = output;
            i++;
        }
        string final = "";
        for (int v = 0; v < arr.Length; v++)
            final += arr[v];

        return final;
    }
    public static void ToUnary(string str)
    {
        string output = "";
        int numberofch = 0;
        foreach (char ch in str)
        {
            numberofch += 1;
        }
        int[] text = new int[numberofch];
        int i = 0;
        foreach (char ch in str)
        {
            int num = ch - '0';
            text[i] = num;
            i++;
        }
        //
        int l = 0;
        bool final = false;
        while (!final)
        {
            int broy0 = 0;
            int broy1 = 0;
            int chislo = -1;

            if (l + 1 != numberofch)
            {
                for (; l < numberofch - 1; l++)
                {
                    chislo = text[l];
                    if (chislo == 0)
                        broy0++;
                    else if (chislo == 1)
                        broy1++;

                    if (text[l + 1] != text[l])
                    {
                        l++;
                        break;
                    }
                }
            }
            int finalAction = -1;
            if (l + 1 == numberofch)
            {
                final = true;
                if (text[numberofch - 1] == 0)
                {
                    broy0++;
                    finalAction = 0;
                }
                else if (text[numberofch - 1] == 1)
                {
                    broy1++;
                    finalAction = 1;
                }
            }

            if (broy0 > 0 && finalAction == -1)
            {
                output += "00 ";

                for (int k = 1; k <= broy0; k++)
                {
                    output += "0";
                }
                if (l + 1 != numberofch || broy1 != 0)
                    output += " ";

            }
            if (broy1 > 0 && finalAction == -1)
            {
                output += "0 ";
                for (int k = 1; k <= broy1; k++)
                {
                    output += "0";
                }
                if (l + 1 != numberofch)
                    output += " ";
            }
            if (finalAction == 0)
            {
                if (broy1 > 0)
                {
                    output += "0 ";
                    for (int k = 1; k <= broy1; k++)
                    {
                        output += "0";
                    }
                    if (l + 1 != numberofch || broy0 != 0)
                        output += " ";
                }
                if (broy0 > 0)
                {
                    output += "00 ";

                    for (int k = 1; k <= broy0; k++)
                    {
                        output += "0";
                    }
                    if (l + 1 != numberofch)
                        output += " ";

                }
                
            } else if (finalAction == 1)
            {
                if (broy0 > 0)
                {
                    output += "00 ";

                    for (int k = 1; k <= broy0; k++)
                    {
                        output += "0";
                    }
                    if (l + 1 != numberofch || broy1 != 0)
                        output += " ";

                }
                if (broy1 > 0)
                {
                    output += "0 ";
                    for (int k = 1; k <= broy1; k++)
                    {
                        output += "0";
                    }
                    if (l + 1 != numberofch)
                        output += " ";
                }
            }

        }
        Console.Write(output);
    }
    public static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();

        string MESSAGE_binary = ToBinary(MESSAGE);
        ToUnary(MESSAGE_binary);
        Console.ReadKey();
    }
    }
