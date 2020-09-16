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

         for (int i = 0; i <= N; i++) {
             for (int j = 0; j <= N; j++) {
                 for (int k = 0; k <= N; k++) {
                     int sum = i * 5 + j * 2 + k * 3;
                     
                     if (sum == N && i >= j) {
                         int tries = i;
                         int trans = j;
                         int penalties = k;
                         Console.WriteLine("{0} {1} {2}", tries, trans, penalties);
                     }
                 }
             }
         }
        
        
    }
}
