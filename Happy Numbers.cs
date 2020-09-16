using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
           string number = Console.ReadLine();
        string fin = number;
        float newNum = 0;

        do
        {
            newNum = 0;
            foreach (float ch in number)
            {
                float num = ch - '0';
                newNum += num * num;
            }
            number = newNum.ToString();
        }
        while ((newNum != 1) && (newNum != 4));
        if (newNum == 1)
        {
            Console.WriteLine(fin + " :)");
        } else
        {
            Console.WriteLine(fin + " :(");
        }
            
        }


    }
}
