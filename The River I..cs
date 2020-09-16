using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    	 static int Sum_chisla(string a) {
		int sum = 0;
		int num;
		foreach (var ch in a) {
			num = ch - '0';
			sum = num + sum;
		}
		return sum;
	}
	public static void Main()
	{
	 	long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());

        
        string r1_string = r1.ToString();
		string r2_string = r2.ToString();
			
				 while (r1 != r2)
        {
            if (r1 < r2)
            {
                r1 = r1 + Sum_chisla(r1.ToString());
            }
            else
            {
                r2 = r2 + Sum_chisla(r2.ToString());
            }
        }

        
        Console.WriteLine(r1);
}
}
