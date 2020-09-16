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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int[] temperature = new int[n];
        int[] Zeros = new int[n];
        int[] Positive = new int[n];
        
        if (n == 0) {
            Console.WriteLine("0");
            
        }
        
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            
            temperature[i] = t;
            
        }
        Array.Sort(temperature);
        for (int h = 0; h < n; h++) {
            
            if (temperature[h] < 0) {
                Zeros[h] = Math.Abs(temperature[h]);
                
            }
            if (temperature[h] > 0) {
                Positive[h] = temperature[h];
            }
            
        }
        Array.Sort(Zeros);
        Array.Sort(Positive);
        int x = 0;
        int y = 0;
        for (int k = 0; k < n; k++) {
            
            if(Positive[n-1] == 0) {
                Positive[y] = 5526;
        }
            if (Positive[k] > 0) {
                y = k;
                break;
            }
            
        }
        for (int k = 0; k < n; k++) {
            if(Zeros[n-1] == 0) {
                Zeros[x] = 5526;
            }
            if (Zeros[k] > 0) {
                x = k;
                
                break;
            }
            
        }
        
        int result = Zeros[x]>=Positive[y]?Positive[y]:(-Zeros[x]);
        Console.WriteLine(result);
    }
}
