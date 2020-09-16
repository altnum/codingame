using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            int max = 0;
            int max2 = 0;
            
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine());
                
                if (max < mountainH) {
                    max = mountainH;
                    max2 = i;
                }
                
            }
            
            Console.WriteLine(max2);

        }
    }
}
