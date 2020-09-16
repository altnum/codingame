using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
       public static string IsNull(decimal ball)
        {
            if (ball > 0 && ball % 2 == 0)
                return "EVEN";
            else if (ball > 0 && ball % 2 != 0)
                return "ODD";
            return "null";
        }
        public static void Main(string[] args)
        {
            int ROUNDS = int.Parse(Console.ReadLine());
            decimal CASH = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < ROUNDS; i++)
            {
                decimal BALL = 0;
                string CALL = "";
                decimal SelectedBALL = 0;
                string[] PLAY = Console.ReadLine().Split(' ');
                decimal bet = Math.Ceiling(0.25m * CASH);

                if (PLAY.Length > 2)
                {
                    BALL = decimal.Parse(PLAY[0]);
                    CALL = PLAY[1];
                    SelectedBALL = decimal.Parse(PLAY[2]);

                    
                    if (BALL == SelectedBALL)
                    {
                        CASH += 35m * bet;
                    }
                    else
                    {
                        CASH -= bet;
                    }
                }
                else
                {
                    BALL = int.Parse(PLAY[0]);
                    CALL = PLAY[1];

                    if (IsNull(BALL) == CALL)
                        CASH += bet;
                    else
                    {
                        CASH -= bet;
                    }
                }
                if (i == ROUNDS - 1)
                {
                    Console.WriteLine(CASH);
                }

            }
}
}
