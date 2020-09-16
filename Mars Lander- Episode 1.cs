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
        string[] inputs;
        int surfaceN = int.Parse(Console.ReadLine());
        for (int i = 0; i < surfaceN; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]);
            int landY = int.Parse(inputs[1]);
        }

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int hSpeed = int.Parse(inputs[2]);
            int vSpeed = int.Parse(inputs[3]);
            int fuel = int.Parse(inputs[4]);
            int rotate = int.Parse(inputs[5]);
            int power = int.Parse(inputs[6]);

            if (vSpeed >= -37) {
                Console.WriteLine("0 0");
            }  
            if (vSpeed <= -37) {
                Console.WriteLine("0 4");
            }
        }
    }
}
