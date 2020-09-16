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
        DateTime BEGIN = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        DateTime END = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

        int days = (END - BEGIN).Days;
        int months = (DateTime.MinValue + (END - BEGIN)).Month - 1;
        int years = days / 365;
        
        
        if (years > 0)
        {
            Console.Write("{0} year{1}, ", years, years > 1 ? "s" : "");
        }

        if (months > 0)
        {
            Console.Write("{0} month{1}, ", months, months > 1 ? "s" : "");
        }

        Console.WriteLine("total {0} days", days);
    }
}
