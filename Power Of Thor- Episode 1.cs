using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]);
        int lightY = int.Parse(inputs[1]);
        int initialTx = int.Parse(inputs[2]);
        int initialTy = int.Parse(inputs[3]);

        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());

            string X = "";
            string Y = "";
            
            if (initialTy > lightY) {
                Y = "N";
                initialTy = initialTy - 1;
            } 
            if (initialTy < lightY) {
                Y = "S";
                initialTy = initialTy + 1;
            }
            if (initialTx > lightX) {
                X = "W";
                initialTx = initialTx - 1;
            }
            if (initialTx < lightX) {
                X = "E";
                initialTx = initialTx + 1;
            }
            Console.WriteLine("{0}{1}", Y, X);
            
        }
    }
}
